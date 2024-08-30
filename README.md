# C-sharp

## Formål
Formålet med dette repository er følgende:

- Lette opsætningen af et udviklingsmiljø til C# programmering.
- At samle eksempler på C# kode, som kan bruges til at lære C# programmering.
 
## Opsætning i Visual Studio Code

1. Installér Visual Studio Code. 
3. Installér .NET Core SDK.
4. Installér C# Dev Kit udvidelsen til Visual Studio Code.
5. Installér Git.
6. Klon dette repository til din computer.
7. Åbn den klonede mappe i Visual Studio Code.
8. Åbn kommando-paletten og vælg `Tasks: Run Task`.
9. Vælg task ved navn `watch and clear terminal`.
10. Åbn kommando-paletten og vælg `Terminal: Focus on Terminal View`. Hver gang du laver en ændring i en fil, vil koden automatisk blive kompileret og kørt. Resultatet vil blive vist i terminalen.

## Debugging i Visual Studio Code

Du kan debugge din kode ved at trykke på `F5`. Du kan også sætte breakpoints i din kode ved at trykke på linjenummeret i Visual Studio Code.

1. Åbn filen, som du vil debugge.
2. Indsæt et breakpoint ved at trykke på linjenummeret.
3. Tryk på `F5` for at starte debugging.


## Ny version af .NET Core SDK

Dette projekt er sat op til at bruge .NET Core SDK version 8.0.

Hvis du har en nyere version af .NET Core SDK installeret, så er det lettest at oprette et nyt projekt med den ønskede version af .NET Core SDK:

```
dotnet new console -n myApp
```

Husk at tilføje projektet til din solution:

```
dotnet sln add myApp/myApp.csproj
```

Når du har tilføjet projektet til din solution, så opretter Visual Studio Code automatisk en `.vscode` mappe med en `launch.json` hhv `tasks.json` filer.