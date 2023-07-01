# Marketing Copilot - demo app

Welcome to the Marketing Copilot demo app which uses OpenAI to generate marketing content based on the information you provide.

The app is a Web .Net Blazor app, using the MudBlazor UI Framework,and the backend is the Azure OpenAI service. 

## Getting Started
-You'll need an Azure OpenAI service account, from which you will get your AzureOpenAI URL, api key.
-.NET 7 to build the app.
-To publish the app, I used Azure App service (Windows based ).

## Building the app
You should just need to add your Azure OpenAI details to the 'appsettings.json' file. 

## Tech in use
-Blazor is an single-page app framework for building client-side web apps using .NET and WebAssembly. 
-MudBlazor is a great UI Framework https://www.mudblazor.com/docs/overview
-Azure OpenAI Service


## caveats / things to do
this really is a first drop, it's not perfect by any means. Top of the list of improvements are;
1. Dynamically create the marketing statement cards rather than having them all duplicated.
2. Remove some unneccessary page components that are handing around from other experiments.
3. 
