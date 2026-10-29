<p align="center">
  <ins><b><kbd>&nbsp;DESKTOP APPLICATION&nbsp;</kbd></b></ins>
</p>

<h1 align="center">🌦️ WEATHER APP (WPF)</h1>

<p align="center">
  <strong>Eine moderne Windows-Desktopanwendung für Wetterinformationen.</strong>
  <br />
  <i>Entwickelt mit C#, WPF und .NET 8.</i>
</p>

<p align="center">
  <a href="#-deutsch">🇩🇪 Deutsch</a> •
  <a href="#-english">🇺🇸 English</a> •
  <a href="#-українська">🇺🇦 Українська</a> •
  <a href="#-русский">🇷🇺 Русский</a>
</p>

---

## 🇩🇪 Deutsch

### 📌 Über das Projekt

WeatherApp is eine Windows-Desktopanwendung, die mit C#, Windows Presentation Foundation (WPF) und .NET 8 entwickelt wurde.

Das Projekt wurde erstellt, um praktische Erfahrungen in der C#-Entwicklung, der Gestaltung grafischer Benutzeroberflächen und dem Aufbau von Windows-Anwendungen zu sammeln.

### 🚀 Funktionen

- **Grafische Benutzeroberfläche:** Eine Desktopoberfläche auf Basis von WPF.
- **C#-Entwicklung:** Implementierung der Anwendungslogik mit C#.
- **.NET 8:** Moderne .NET-Plattform für Windows-Anwendungen.
- **Windows-x64-Version:** Veröffentlichung als ausführbare Anwendung für 64-Bit-Windows-Systeme.
- **Standalone-Veröffentlichung:** Veröffentlichung mit integriertem .NET Runtime, um die Abhängigkeit von einer separat installierten Runtime zu reduzieren.

### 🛠️ Technologien

- **Programmiersprache:** C#
- **Framework:** .NET 8
- **Benutzeroberfläche:** Windows Presentation Foundation (WPF), XAML
- **Entwicklungsumgebung:** Visual Studio
- **Build und Veröffentlichung:** .NET CLI (`dotnet publish`)
- **Versionsverwaltung:** Git und GitHub

### 📦 Installation und Ausführung

#### Option 1: Fertige Anwendung herunterladen

1. Öffne den Bereich **Releases** dieses GitHub-Repositories.
2. Lade die veröffentlichte Datei `WeatherApp.exe` herunter.
3. Starte die Anwendung unter Windows.

> Hinweis: Die ausführbare Datei wurde für Windows x64 veröffentlicht. Die tatsächliche Kompatibilität sollte auf dem Zielsystem getestet werden.

#### Option 2: Projekt selbst erstellen

Voraussetzungen:
- Windows
- .NET 8 SDK
- Git

1. Repository klonen:

   ```bash
   git clone https://github.com/KristinaAlokhina/WeatherApp-WPF.git
   ```

2. In das Projektverzeichnis wechseln:

   ```bash
   cd WeatherApp-WPF
   ```

3. Anwendung im Release-Modus veröffentlichen:

   ```bash
   dotnet publish WeatherApp.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
   ```

4. Die veröffentlichte Anwendung befindet sich normalerweise im Verzeichnis:

   ```text
   bin/Release/net8.0-windows/win-x64/publish/
   ```

### 🎯 Projektziel

Dieses Projekt ist Teil meiner praktischen Weiterentwicklung in der Softwareentwicklung. Dabei vertiefe ich meine Kenntnisse in C#, .NET, XAML und der Entwicklung grafischer Benutzeroberflächen.

---

## 🇺🇸 English

### 📌 About the Project

WeatherApp is a Windows desktop application developed using C#, Windows Presentation Foundation (WPF), and .NET 8.

The project was created to gain practical experience in C# programming, graphical user interface design, and Windows application development.

### 🚀 Features

- **Graphical User Interface:** A desktop interface built with WPF.
- **C# Development:** Application logic implemented in C#.
- **.NET 8:** A modern framework for Windows applications.
- **Windows x64 Build:** Published as an executable application for 64-bit Windows systems.
- **Standalone Publishing:** Published with the .NET runtime included to reduce the need for a separately installed runtime.

### 🛠️ Technologies

- **Programming Language:** C#
- **Framework:** .NET 8
- **User Interface:** Windows Presentation Foundation (WPF), XAML
- **IDE:** Visual Studio
- **Build and Publishing:** .NET CLI (`dotnet publish`)
- **Version Control:** Git and GitHub

### 📦 Installation and Setup

#### Option 1: Download the Prebuilt Application

1. Open the **Releases** section of this GitHub repository.
2. Download the published `WeatherApp.exe` file.
3. Run the application on Windows.

> Note: The executable was published for Windows x64. Compatibility should be tested on the target system.

#### Option 2: Build from Source

Requirements:
- Windows
- .NET 8 SDK
- Git

1. Clone the repository:

   ```bash
   git clone https://github.com/KristinaAlokhina/WeatherApp-WPF.git
   ```

2. Navigate to the project directory:

   ```bash
   cd WeatherApp-WPF
   ```

3. Publish the application in Release mode:

   ```bash
   dotnet publish WeatherApp.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
   ```

4. The published application can normally be found in:

   ```text
   bin/Release/net8.0-windows/win-x64/publish/
   ```

### 🎯 Project Goal

This project is part of my practical learning journey in software development. It helps me strengthen my skills in C#, .NET, XAML, and graphical user interface development.

---

## 🇺🇦 Українська

### 📌 Про проєкт

WeatherApp — це десктопний додаток для Windows, розроблений на C#, Windows Presentation Foundation (WPF) та .NET 8.

Проєкт створено для отримання практичного досвіду в розробці на C#, проєктуванні графічних інтерфейсів користувача та створенні додатків для Windows.

### 🚀 Функції

- **Графічний інтерфейс користувача:** Десктопний інтерфейс на базі WPF.
- **Розробка на C#:** Реалізація логіки додатка на мові C#.
- **.NET 8:** Сучасна платформа .NET для Windows-додатків.
- **Версія для Windows x64:** Публікація у вигляді виконуваного файлу для 64-бітних систем Windows.
- **Автономна публікація:** Збірка зі вбудованим середовищем виконання .NET Runtime для роботи без необхідності окремого встановлення платформи.

### 🛠️ Технології

- **Мова програмування:** C#
- **Платформа:** .NET 8
- **Інтерфейс користувача:** Windows Presentation Foundation (WPF), XAML
- **Середовище розробки:** Visual Studio
- **Збірка та публікація:** .NET CLI (`dotnet publish`)
- **Управління версіями:** Git та GitHub

### 📦 Встановлення та запуск

#### Варіант 1: Завантажити готовий додаток

1. Відкрийте розділ **Releases** у цьому GitHub-репозиторії.
2. Завантажте опублікований файл `WeatherApp.exe`.
3. Запустіть додаток у Windows.

> Примітка: Виконуваний файл зібрано для Windows x64. Фактичну сумісність необхідно перевіряти на цільовій системі.

#### Варіант 2: Самостійна збірка проєкту

Вимоги:
- Windows
- .NET 8 SDK
- Git

1. Клонувати репозиторій:

   ```bash
   git clone https://github.com/KristinaAlokhina/WeatherApp-WPF.git
   ```

2. Перейти до каталогу проєкту:

   ```bash
   cd WeatherApp-WPF
   ```

3. Опублікувати додаток у режимі Release:

   ```bash
   dotnet publish WeatherApp.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
   ```

4. Опублікований додаток зазвичай знаходиться в каталозі:

   ```text
   bin/Release/net8.0-windows/win-x64/publish/
   ```

### 🎯 Мета проєкту

Цей проєкт є частиною мого практичного навчання та розвитку у сфері розробки програмного забезпечення. Він допомагає мені вдосконалювати навички роботи з C#, .NET, XAML та проектування графічних інтерфейсів користувача.

---

## 🇷🇺 Русский

### 📌 О проекте

WeatherApp — это десктопное приложение для Windows, разработанное на C#, Windows Presentation Foundation (WPF) и .NET 8.

Проект создан для получения практического опыта в разработке на C#, проектировании графических интерфейсов пользователя и создании приложений для Windows.

### 🚀 Функции

- **Графический интерфейс:** Десктопный интерфейс на базе WPF.
- **Разработка на C#:** Реализация логики приложения на языке C#.
- **.NET 8:** Современная платформа .NET для Windows-приложений.
- **Версия для Windows x64:** Публикация в виде исполняемого файла для 64-битных систем Windows.
- **Автономная публикация:** Сборка со встроенной средой выполнения .NET Runtime для работы без необходимости отдельной установки платформы.

### 🛠️ Technologien

- **Язык программирования:** C#
- **Платформа:** .NET 8
- **Интерфейс пользователя:** Windows Presentation Foundation (WPF), XAML
- **Среда разработки:** Visual Studio
- **Сборка и публикация:** .NET CLI (`dotnet publish`)
- **Управление версиями:** Git и GitHub

### 📦 Установка и запуск

#### Вариант 1: Скачать готовое приложение

1. Откройте раздел **Releases** в данном GitHub-репозитории.
2. Скачайте опубликованный файл `WeatherApp.exe`.
3. Запустите приложение в Windows.

> Примечание: Исполняемый файл собран для Windows x64. Фактическую совместимость необходимо проверять на целевой системе.

#### Вариант 2: Самостоятельная сборка проекта

Требования:
- Windows
- .NET 8 SDK
- Git

1. Клонировать репозиторий:

   ```bash
   git clone https://github.com/KristinaAlokhina/WeatherApp-WPF.git
   ```

2. Перейти в каталог проекта:

   ```bash
   cd WeatherApp-WPF
   ```

3. Опубликовать приложение в режиме Release:

   ```bash
   dotnet publish WeatherApp.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
   ```

4. Опубликованное приложение обычно находится в каталоге:

   ```text
   bin/Release/net8.0-windows/win-x64/publish/
   ```

### 🎯 Цель проекта

Этот продукт представляет собой практичный продукт с розовой сферой для разработки программного обеспечения. В меню показано, как управлять роботами в C#, .NET и графических интерфейсах.

