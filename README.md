# WheatherForecastBlazorWithRedisCache
REDIS Cache with C# Weather Forecast Blazor App

-----------------------------------------------------------------------------------------------------------------------------
Documentation
-----------------------------------------------------------------------------------------------------------------------------
https://www.youtube.com/watch?v=UrQWii_kfIE&t
https://www.youtube.com/watch?v=KUmXD_ubJU0

-----------------------------------------------------------------------------------------------------------------------------
Start container and clone existing repository 
-----------------------------------------------------------------------------------------------------------------------------

In github
1) create repository 

2) F1 command palette in visual studio code 
dev containers: Clone repository in container Volume

3) créartion du projet dotnet blazor server

>dotnet workload update
La commande dotnet workload update est utilisée pour mettre à jour les workloads .NET installés sur votre machine. Les workloads sont des extensions facultatives du SDK .NET, permettant d'ajouter des fonctionnalités spécifiques comme :

MAUI (Multi-platform App UI)
Blazor WebAssembly AOT
ASP.NET Core Blazor Hybrid
Développement IoT, Machine Learning, etc.

>dotnet new --list
>dotnet new blazor

4) git identity

Configurez votre nom :
> git config --global user.name "Votre Nom"
Configurez votre adresse e-mail :
> git config --global user.email "votre.email@example.com"
Vérifier la configuration :
Pour vérifier que vos informations sont correctement configurées, vous pouvez exécuter :
> git config --global --list

-----------------------------------------------------------------------------------------------------------------------------
Redis package
-----------------------------------------------------------------------------------------------------------------------------
> dotnet add package Microsoft.Extensions.Caching.StackExchangeRedis
> dotnet add package StackExchange.Redis