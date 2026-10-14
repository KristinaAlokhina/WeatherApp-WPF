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
  <a href="#-english">🇺🇸 English</a>
</p>

---

## 🇩🇪 Deutsch

### 📌 Über das Projekt

WeatherApp ist eine Windows-Desktopanwendung, die mit C#, Windows Presentation Foundation (WPF) und .NET 8 entwickelt wurde.

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

<p align="center">
  <i>Developed as a personal learning project.</i>
</p>
