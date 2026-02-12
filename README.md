StudentManagement.OnionArchitecture
📌 Overview

StudentManagement.OnionArchitecture is a .NET-based Student Management System built using Onion Architecture principles.
The project demonstrates clean separation of concerns, dependency inversion, and scalable layered design.

It is structured into four core layers:

Domain

Application

Infrastructure

Presentation

The solution is designed to be maintainable, testable, and independent of frameworks or external dependencies at its core.

🧅 Architecture

This project follows Onion Architecture, where dependencies flow inward:

Presentation → Infrastructure → Application → Domain

🔹 Domain Layer

Core business entities (e.g., Student)

Business rules

Interfaces (Repository contracts)

No external dependencies

🔹 Application Layer

Use cases (Create, Update, Delete, Get Students)

DTOs

Service interfaces

Business workflows

🔹 Infrastructure Layer

EF Core implementations

Database context

Repository implementations

External service integrations

🔹 Presentation Layer

ASP.NET Core Web API

Controllers

API endpoints

Dependency Injection configuration

🚀 Features

Add new students

Update student details

Delete students

Retrieve student by ID

Retrieve all students

Clean separation of business logic

Dependency inversion principle implemented

🛠️ Tech Stack

.NET / ASP.NET Core

C#

Entity Framework Core

SQL Server (or your DB)

Onion Architecture Pattern

Dependency Injection


🎯 Purpose

This project was created to demonstrate:

Implementation of Onion Architecture in .NET

Clean separation of concerns

Repository pattern usage

Enterprise-level project structure

Scalable backend design principles
