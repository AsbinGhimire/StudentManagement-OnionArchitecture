StudentManagement.OnionArchitecture
Overview

StudentManagement.OnionArchitecture is a .NET-based Student Management System implemented using Onion Architecture principles. The project demonstrates clean separation of concerns, dependency inversion, and a scalable layered structure suitable for enterprise-grade applications.

The solution is designed to keep the core business logic independent from infrastructure and external frameworks.

Architecture

This project follows the Onion Architecture pattern, where dependencies flow inward toward the core domain layer.

Presentation → Infrastructure → Application → Domain

Domain

Core business entities (e.g., Student)

Business rules

Repository interfaces

No external framework dependencies

Application

Use cases (Create, Update, Delete, Retrieve Students)

DTOs

Service abstractions

Business workflows

Infrastructure

Entity Framework Core implementation

Repository implementations

Database context

External service integrations

Presentation

ASP.NET Core Web API

Controllers and endpoints

Dependency injection configuration

Features

Create student records

Update student information

Delete student records

Retrieve student by ID

Retrieve all students

Clean layered architecture

Dependency inversion principle implementation

Technology Stack

.NET / ASP.NET Core

C#

Entity Framework Core

SQL Server

Onion Architecture

Dependency Injection

Project Structure
StudentManagement.OnionArchitecture.sln
│
├── StudentManagement.Domain
├── StudentManagement.Application
├── StudentManagement.Infrastructure
└── StudentManagement.Presentation

Design Principles

Separation of concerns

Single Responsibility Principle

Dependency inversion

Framework-independent domain layer

Testable business logic

Getting Started

Clone the repository

Configure the database connection string

Apply migrations (if applicable)

Run the Presentation project
