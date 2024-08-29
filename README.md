# 🎵 MusicWebApp

MusicWebApp is an ASP.NET Core Web API application designed to manage a collection of songs. This API allows you to perform CRUD (Create, Read, Update, Delete) operations on a songs database using RESTful endpoints. The project is built using ASP.NET Core 7.0, Entity Framework Core, and MySQL.

## 📖 Overview

The **MusicWebApp** provides the following functionalities:

- **GET** all songs in the playlist.
- **GET** a specific song by its ID.
- **POST** a new song to the playlist.
- **PUT** (update) an existing song's details.
- **DELETE** a song from the playlist.

## 🚀 Features

- **RESTful API**: Provides a simple, intuitive interface for managing songs.
- **Entity Framework Core**: Utilizes EF Core for database operations with MySQL backend.
- **Swagger/OpenAPI Integration**: Easily explore and test API endpoints directly in the browser.
- **Migrations**: Includes EF Core migrations to set up and maintain the database schema.

## 🛠️ Technologies Used

- **ASP.NET Core 7.0**: Framework for building the web API.
- **Entity Framework Core 7.0**: ORM for database interactions.
- **MySQL**: Database used to store song data.
- **Swagger/OpenAPI**: Documentation and testing tool integrated into the project.
- **C#**: Primary programming language for developing the API.

## 📂 Project Structure

- **Controllers**: Contains `SongsController` which handles API requests.
- **Data**: Includes `ApplicationDbContext` for EF Core database context.
- **Models**: Contains the `Song` model representing the song entity in the database.
- **Migrations**: Auto-generated EF Core migrations for database schema updates.
- **Properties**: Contains launch settings for different environments.
- **appsettings.json**: Configuration file for database connections and logging.

## 📝 Getting Started

### Prerequisites

- .NET 7.0 SDK
- MySQL Server

