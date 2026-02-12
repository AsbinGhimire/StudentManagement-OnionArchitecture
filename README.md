**StudentManagement.OnionArchitecture**
Overview

StudentManagement.OnionArchitecture is a .NET-based Student Management System built using Onion Architecture principles.

The project demonstrates:

Clean separation of concerns

Dependency inversion

Scalable layered structure

Framework-independent domain design

The core business logic remains isolated from infrastructure and external frameworks, making the system maintainable, testable, and extensible.

**Architecture**

This solution follows the Onion Architecture pattern, where dependencies flow inward toward the core domain layer.

Presentation → Infrastructure → Application → Domain

**Layer Responsibilities**
Domain (Core Layer)

Core business entities (e.g., Student)

Business rules and validations

Repository interfaces (contracts)

No dependency on external frameworks

**Application**

Use cases (Create, Update, Delete, Retrieve Students)

DTOs (Data Transfer Objects)

Service abstractions

Business workflows and orchestration

**Infrastructure**

Entity Framework Core implementation

Repository implementations

Database context configuration

External service integrations

**Presentation**

ASP.NET Core Web API

Controllers and HTTP endpoints

Dependency injection configuration

API routing and request handling

**Features**

Create student records

Update student information

Delete student records

Retrieve student by ID

Retrieve all students

Structured layered architecture

Implementation of Dependency Inversion Principle

**Technology Stack**

.NET / ASP.NET Core

C#

Entity Framework Core

SQL Server

Onion Architecture Pattern

Built-in Dependency Injection

**Project Structure**
StudentManagement.OnionArchitecture.sln
│
├── StudentManagement.Domain
├── StudentManagement.Application
├── StudentManagement.Infrastructure
└── StudentManagement.Presentation


Each project has a clearly defined responsibility to enforce separation of concerns and maintain clean architectural boundaries.

**Design Principles**

Separation of Concerns

Single Responsibility Principle (SRP)

Dependency Inversion Principle (DIP)

Framework-Independent Domain Layer

Testable Business Logic

**Getting Started**
1️⃣ Clone the Repository
git clone https://github.com/your-username/StudentManagement.OnionArchitecture.git

2️⃣ Configure Database

Update the connection string in:

appsettings.json

3️⃣ Apply Migrations (If Applicable)
dotnet ef database update

4️⃣ Run the Application
dotnet run --project StudentManagement.Presentation


The API will start and be accessible via Swagger (if enabled).
