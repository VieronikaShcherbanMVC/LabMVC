\# System zarządzania zadaniami domowymi



\# Spis treści



\- Opis projektu

\- Funkcjonalności

\- Technologie

\- Struktura MVC

\- Instrukcja uruchomienia

\- Autor



\---



\# Opis projektu



Projekt został wykonany w technologii ASP.NET Core MVC.



Aplikacja umożliwia zarządzanie zadaniami domowymi poprzez:

\- dodawanie nowych zadań

\- edytowanie istniejących zadań

\- usuwanie zadań

\- filtrowanie zadań według statusu



Projekt wykorzystuje wzorzec architektoniczny MVC (Model-View-Controller).



\---



\# Funkcjonalności



\## Podstawowe funkcjonalności CRUD



\- Dodawanie nowych zadań

\- Wyświetlanie listy zadań

\- Edytowanie zadań

\- Usuwanie zadań



\---



\## Dodatkowe funkcjonalności



\- Filtrowanie zadań według statusu

\- Walidacja formularzy

\- Priorytety zadań:

&#x20; - Niski

&#x20; - Średni

&#x20; - Wysoki

\- Stylizacja interfejsu przy użyciu Bootstrap

\- Przechowywanie danych w bazie SQL Server

\- Entity Framework Core



\---



\# Technologie



\- ASP.NET Core MVC

\- C#

\- Entity Framework Core

\- SQL Server LocalDB

\- Bootstrap

\- Razor Views



\---



\# Struktura MVC



\## Model



Model `HomeworkTask` zawiera:

\- opis zadania

\- termin wykonania

\- status

\- priorytet



\## View



Widoki odpowiadają za:

\- wyświetlanie listy zadań

\- formularz dodawania

\- formularz edycji



\## Controller



Kontroler `TasksController` obsługuje:

\- żądania HTTP

\- operacje CRUD

\- filtrowanie danych



\---



\# Instrukcja uruchomienia projektu



\## 1. Sklonuj repozytorium



```bash

git clone https://github.com/VieronikaShcherbanMVC/LabMVC

```

\# Autor



Vieronika Shcherban

Grupa L1

Nr albumu: 61387



