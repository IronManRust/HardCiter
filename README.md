# HardCiter Service

![HardCiter Logo](./README-logo.png "HardCiter Logo")

## Demo

Try it out!

[https://hard-citer.herokuapp.com](https://hard-citer.herokuapp.com)

## Description

This service provides bibliographic and citation information in various styles.

While supporting an extensible architecture, the initial implementation uses CiteProc / CSL for processing:

* [CiteProc Wikipedia Entry](https://en.wikipedia.org/wiki/CiteProc)
* [CiteProc Manual](https://citeproc-js.readthedocs.io)
* [CSL Specification](https://docs.citationstyles.org/en/1.0.1/specification.html)

## Requirements

This package is built on the following technologies:

* [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)
* [Node.js](https://nodejs.org/en/)

Given that .NET Core and Node.js are cross-platform, it should run successfully on Windows, MacOS and Linux.

## Screenshot

![HardCiter Screenshot](./README-screenshot.png "HardCiter Screenshot")

## Build Tasks

The following tasks are available from the root (`./`) directory:

* `dotnet clean HardCiter.sln /p:Configuration="{Debug|Release}"` - Cleans the solution.
* `dotnet build HardCiter.sln /p:Configuration="{Debug|Release}"` - Compiles the solution.
* `dotnet test HardCiter.sln /p:Configuration="{Debug|Release}" /p:EnvironmentName="{Local|DEV|QA|Stage|Production}" /p:CollectCoverage="True" /p:CoverletOutput="./TestCoverage/" /p:CoverletOutputFormat="{JSON|LCOV|OpenCover|Cobertura}"` - Runs all unit tests in the solution and generates a code coverage report.
* `dotnet publish HardCiter.sln /p:Configuration="{Debug|Release}" /p:EnvironmentName="{Local|DEV|QA|Stage|Production}"` - Creates a deployment package suitable for hosting.

The following tasks are available from the service project (`./HardCiter.Service`) directory:

* `dotnet run --Environment "{Local|DEV|QA|Stage|Production}"` - Starts Kestrel on the port specified in the `launchSettings.json` file (by default [https://localhost:6800](https://localhost:6800)).

## Usage Examples

Create a Chicago v17 HTML citation for Moby Dick:

```HTTP
curl
-X POST "https://hard-citer.herokuapp.com/api/1.0/citation/book?style=Chicago17&format=HTML"
-H "accept: application/json"
-H "Content-Type: application/json"
-d
"{
  \"titleFull\": \"Moby Dick\",
  \"authors\": [
    {
      \"given\": \"Herman\",
      \"family\": \"Melville\"
    }
  ],
  \"accessedDate\": {
    \"dateType\": \"ExactFull\",
    \"dateExact\": \"2020-05-23T15:30:00.000Z\"
  },
  \"issuedDate\": {
    \"dateType\": \"ExactPartial\",
    \"year\": 2003,
    \"month\": 5,
    \"day\": 1
  },
  \"abstract\": \"On a previous voyage, a mysterious white whale had ripped off the leg of a sea captain named Ahab. Now the crew of the Pequod, on a pursuit that features constant adventure and horrendous mishaps, must follow the mad Ahab into the abyss to satisfy his unslakeable thirst for vengeance.\",
  \"language\": \"English\",
  \"note\": \"This is a good book for my term paper.\",
  \"url\": \"https://www.barnesandnoble.com/w/moby-dick-melville-herman/1110282307\",
  \"publisherName\": \"Barnes & Noble\",
  \"publisherLocation\": \"Lyndhurst, New Jersey\",
  \"isbn\": \"9781593080181\",
  \"editors\": [
    {
      \"given\": \"Charles Child\",
      \"family\": \"Walcutt\"
    }
  ],
  \"collectionTitle\": \"Barnes & Noble Classics Series\",
  \"pageCount\": 752
}"
```

```JSON
{
  "value": "Herman Melville, <i>Moby Dick</i>, ed. Charles Child Walcutt, Barnes &#38; Noble Classics Series (Lyndhurst, New Jersey: Barnes &#38; Noble, 2003), https://www.barnesandnoble.com/w/moby-dick-melville-herman/1110282307."
}
```

Create a MLA v8 HTML citation for Alice in Wonderland:

```HTTP
curl
-X POST "https://hard-citer.herokuapp.com/api/1.0/citation/book?style=MLA8&format=HTML"
-H "accept: application/json"
-H "Content-Type: application/json"
-d
"{
  \"titleFull\": \"Alice's Adventures in Wonderland and Through the Looking-Glass\",
  \"authors\": [
    {
      \"given\": \"Lewis\",
      \"family\": \"Carroll\"
    }
  ],
  \"accessedDate\": {
    \"dateType\": \"ExactFull\",
    \"dateExact\": \"2020-05-23T15:30:00.000Z\"
  },
  \"issuedDate\": {
    \"dateType\": \"ExactPartial\",
    \"year\": 2015,
    \"month\": 3,
    \"day\": 27
  },
  \"abstract\": \"Alice's Adventures in Wonderland transports you down the rabbit-hole into a wondrous realm that is home to a White Rabbit, a March Hare, a Mad Hatter, a tea-drinking Dormouse, a grinning Cheshire-Cat, the Queen of Hearts and her playing-card retainers, and all manner of marvelous creatures.\",
  \"language\": \"English\",
  \"note\": \"Use this book in my speech.\",
  \"url\": \"https://www.barnesandnoble.com/w/alices-adventures-in-wonderland-and-through-the-looking-glass-carroll-lewis/1119355717\",
  \"publisherName\": \"Barnes & Noble\",
  \"publisherLocation\": \"Lyndhurst, New Jersey\",
  \"isbn\": \"9781435159549\",
  \"collectionTitle\": \"Barnes & Noble Collectible Editions Series\",
  \"pageCount\": 240
}"
```

```JSON
{
  "value": "(Carroll)"
}
```

Create an APA v7 HTML bibliography for both:

```HTTP
curl
-X POST "https://hard-citer.herokuapp.com/api/1.0/bibliography?style=APA7&format=HTML"
-H "accept: application/json"
-H "Content-Type: application/json"
-d
"[
{
  \"itemType\": \"Book\",
  \"titleFull\": \"Moby Dick\",
  \"authors\": [
    {
      \"given\": \"Herman\",
      \"family\": \"Melville\"
    }
  ],
  \"accessedDate\": {
    \"dateType\": \"ExactFull\",
    \"dateExact\": \"2020-05-23T15:30:00.000Z\"
  },
  \"issuedDate\": {
    \"dateType\": \"ExactPartial\",
    \"year\": 2003,
    \"month\": 5,
    \"day\": 1
  },
  \"abstract\": \"On a previous voyage, a mysterious white whale had ripped off the leg of a sea captain named Ahab. Now the crew of the Pequod, on a pursuit that features constant adventure and horrendous mishaps, must follow the mad Ahab into the abyss to satisfy his unslakeable thirst for vengeance.\",
  \"language\": \"English\",
  \"note\": \"This is a good book for my term paper.\",
  \"url\": \"https://www.barnesandnoble.com/w/moby-dick-melville-herman/1110282307\",
  \"publisherName\": \"Barnes & Noble\",
  \"publisherLocation\": \"Lyndhurst, New Jersey\",
  \"isbn\": \"9781593080181\",
  \"editors\": [
    {
      \"given\": \"Charles Child\",
      \"family\": \"Walcutt\"
    }
  ],
  \"collectionTitle\": \"Barnes & Noble Classics Series\",
  \"pageCount\": 752
},
{
  \"itemType\": \"Book\",
  \"titleFull\": \"Alice's Adventures in Wonderland and Through the Looking-Glass\",
  \"authors\": [
    {
      \"given\": \"Lewis\",
      \"family\": \"Carroll\"
    }
  ],
  \"accessedDate\": {
    \"dateType\": \"ExactFull\",
    \"dateExact\": \"2020-05-23T15:30:00.000Z\"
  },
  \"issuedDate\": {
    \"dateType\": \"ExactPartial\",
    \"year\": 2015,
    \"month\": 3,
    \"day\": 27
  },
  \"abstract\": \"Alice's Adventures in Wonderland transports you down the rabbit-hole into a wondrous realm that is home to a White Rabbit, a March Hare, a Mad Hatter, a tea-drinking Dormouse, a grinning Cheshire-Cat, the Queen of Hearts and her playing-card retainers, and all manner of marvelous creatures.\",
  \"language\": \"English\",
  \"note\": \"Use this book in my speech.\",
  \"url\": \"https://www.barnesandnoble.com/w/alices-adventures-in-wonderland-and-through-the-looking-glass-carroll-lewis/1119355717\",
  \"publisherName\": \"Barnes & Noble\",
  \"publisherLocation\": \"Lyndhurst, New Jersey\",
  \"isbn\": \"9781435159549\",
  \"collectionTitle\": \"Barnes & Noble Collectible Editions Series\",
  \"pageCount\": 240
}
]"
```

```JSON
{
  "spacingEntry": 0,
  "spacingLine": 2,
  "hangingIndent": true,
  "values": [
    "  <div class=\"csl-entry\">Carroll, L. (2015). <i>Alice’s Adventures in Wonderland and Through the Looking-Glass</i>. Barnes &#38; Noble. https://www.barnesandnoble.com/w/alices-adventures-in-wonderland-and-through-the-looking-glass-carroll-lewis/1119355717</div>",
    "  <div class=\"csl-entry\">Melville, H. (2003). <i>Moby Dick</i> (C. C. Walcutt, Ed.). Barnes &#38; Noble. https://www.barnesandnoble.com/w/moby-dick-melville-herman/1110282307</div>"
  ]
}
```

## Client Generation Tasks

While there are multiple ways to consume a REST-ful service, a useful tool to consider when configuring a client is [AutoRest](https://github.com/Azure/autorest). It is a Node.js package that supports the following target languages:

* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --csharp` - Generate C# client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --nodejs` - Generate Node.js / JavaScript client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --python` - Generate Python client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --java` - Generate Java client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --ruby` - Generate Ruby client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --go` - Generate Go client files.
* `autorest --input-file="swagger.json" --output-folder="./code/" --namespace="HardCiter" --typescript` - Generate TypeScript client files.

## Acknowledgements

Many thanks to Nancy for lending me her librarian skills in sanity checking the output of this service.

## TODO List

* [Update CSL Processor](https://github.com/Juris-M/citeproc-js/releases)
* Update .NET Framework Target (`netcoreapp2.1` → `netcoreapp3.1`)
* Update Node.js Library
  * Reasoning - [Obsoleting Microsoft.AspNetCore.NodeServices](https://github.com/dotnet/aspnetcore/issues/12890)
  * Existing - [Microsoft.AspNetCore.NodeServices](https://www.nuget.org/packages/Microsoft.AspNetCore.NodeServices/)
  * Replacement - [Jering.Javascript.NodeJS](https://www.nuget.org/packages/Jering.Javascript.NodeJS/)
