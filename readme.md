# Treender - hackaton app
Bez choinki świąt nie będzie. Znajdź tą jedyną na treenderze!

# Idea 
Choinka to nie odłączy element świąt. Znalezienie i kupienie odpowiedniej choinki często sprawia kłopot
i nie jest najciekawszym zajęciem. Treender ma za zadanie to zmienić i uratować twoje święta! Dzięki Treenderowi znajdziesz najlepsze choinki w twojej okolicy. Propozycje są dobierane według preferencji przypisanych do profilu, więc nie tracisz czasu i przeglądasz tylko to co Cię interesuje.

# Progress

## Features planned
* Creating user profile
* Main swiping screen
* Customizing preferences
* Browsing liked trees

## Features completed
* Creating user profile
* Main swiping screen
* Database dockerization

## Features given up
* Authentication/Authorization/Session... just passwords and stuff
* Customizing prefernces (run out of time)
* Contenerizing application (weird dotnet exit code)


# How to run it

## Database
* download database [here](https://drive.google.com/open?id=1UZ3qk-RSMgt0t_E3956qAIwYvPUjUit8)
* unzip it & cd into docker-base
* run: docker-compose build && docker-compose up

## Application
* launch solution in visual studio
* make sure "Treender" launch profile is selected
* run project

# Technologies used
* ASP.NET Core 3.0 & React.js
* PostgreSQL & pgAdmin 4
* docker-compose 
