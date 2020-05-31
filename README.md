![Parks and Rec dot NET Client Logo](https://parksandrecapi.com/img/parks-rec-client.png)

# Overview
Welcometo the  .NET client for the [Parks and Rec API](https://github.com/htedeschi/parks-and-rec-api).  For information and documentation for the API, check the [API Wiki](https://github.com/htedeschi/parks-and-rec-api/wiki).

## Usage
### Token 
First things first, right? To use this API you'll need a Token. To request a token, go to [www.parksandrecapi.com](https://www.parksandrecapi.com/) and follow the steps.


### Client
To implement the Library into your project, install the [NuGet package](https://www.nuget.org/packages/ParksRecClient/) into your solution/project by running it in the Package Manager Console:
```
PM> Install-Package ParksRecClient -Version 1.0.0
```

Or by searching ParksRecClient in the Package Manager searching bar.

To implement the client into your project, include the `ParksRec.Client` namespace:
```csharp
using ParksRec.Client;
```

To instantiate a new client in your program, include the following:

```csharp
ParksRecConfig parksRecConfig = new ParksRecConfig {Token = "<TOKEN>"};

ParksRecClient client = new ParksRecClient(parksRecConfig);
```

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

### Band Names
To retrieve the band names, you can use:
```csharp
var bands = await client.Bands.Get();
```

Or, to use the name filter, use:
```csharp
var bands = await client.Bands.Get("name of band");
```

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

### Characters
To retrieve the characters of the show, you can use:

```csharp
var characters = await client.Characters.Get();
```

Or, to use the name filter, use:

```csharp
var characters = await client.Characters.Get("leslie");
```

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

### Episodes
To retrieve the episodes, you can use:

```csharp
var episodes = await client.Episodes.Get();
```

Or, to filter by the title of the episode, use:

```csharp
var episodes = await client.Episodes.Get("knope");
```

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

### Seasons
To retrieve the seasons, you can use:

```csharp
var seasons = await client.Seasons.Get();
```

Or, to filter by the season, use:

```csharp
var seasons = await client.Seasons.Get("special");
```
<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

## Author
**[Henrique Tedeschi](https://github.com/htedeschi)**

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

## Disclaimer
This library is provided *"as is"* without expressed or implied warranty of any kind. Please use at your own risk and discretion.
<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>

## License
This API is provided under the MIT License. See the [LICENSE](https://github.com/htedeschi/parks-rec-dotnet-client/blob/master/LICENSE) file for details.

<br/>
<div align="right">
    <b><a href="#overview">↥ back to top</a></b>
</div>
<br/>
