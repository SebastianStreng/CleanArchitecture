# CleanArchitecture
readme_content = """# Clean Architecture WPF Example

This project is an **example WPF application** designed to demonstrate the core principles of **Clean Architecture**, **Dependency Injection**, and the **Dependency Inversion Principle**.

## 🔧 Architecture Overview

The application is structured into four distinct layers, each with a specific responsibility:

### 1. **Domain**
- Contains only the most fundamental building blocks.
- This includes **class definitions**, **interfaces**, and core **domain models**.
- No dependencies to other layers or external systems.

### 2. **Application**
- Hosts the **business logic** of the application.
- Uses interfaces from the Domain layer.
- Depends only on the Domain layer.

### 3. **Infrastructure**
- Contains everything related to external systems or implementations, such as:
  - **Database access**
  - **File I/O**
  - **Third-party services**
- Implements interfaces from the Domain or Application layers.

### 4. **Presentation**
- This is the **WPF UI** (or would be an API in other project types).
- Responsible for interacting with the user.
- Calls services from the Application layer using **interfaces**.

## 📦 Dependency Management

To ensure proper decoupling and adherence to Clean Architecture principles:

- Dependencies only flow **inward** (from outer layers to inner layers).
- Services are defined via **interfaces** in the Domain or Application layer.
- Implementations are injected at runtime using **Dependency Injection (DI)**.
- Service registration is handled in the `App.xaml.cs` (for WPF) or `Program.cs` (for console/web apps) using `IServiceCollection`.

## ✅ Key Principles Demonstrated

- **Separation of concerns**
- **Inversion of dependencies using interfaces**
- **Testable and maintainable structure**
- **Independent application core**
"""