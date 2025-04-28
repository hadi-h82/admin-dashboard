# AdminDashboardApi

This project is based on a **Layered Architecture** and follows **Clean Architecture** principles.

## 📁 Project Structure

AdminDashboardApi
│
├── Application           # Layer for implementing business logic.
│   ├── Interfaces        # Contains service interfaces and contracts.
│   └── Services          # Contains business logic service classes.
│
├── Domain                # Layer for core domain models and entities (like User, Role).
│   ├── Entities          # Domain entities (e.g., User, Role, Permission).
│   └── Enums             # Domain-specific enums such as RoleType.
│
├── Infrastructure        # Layer for external dependencies (e.g., database, filesystem, external APIs).
│   ├── Data              # Database configurations and context classes.
│   ├── Repositories      # Data access classes.
│   └── Services          # Infrastructure-level services.
│
├── Presentation          # Layer for API endpoints and UI-related concerns.
│   ├── Controllers       # API controllers.
│   └── Models            # DTOs and API request/response models.
│
└── Shared                # Common/shared utilities like Helpers and Exceptions.

---

## 🛠️ Technologies Used

- ASP.NET Core 9.0
- Clean Architecture Principles
- JWT Authentication/Authorization (planned for future phases)
- Entity Framework Core (planned for database management)

---

## 🚀 How to Run the Project

1. Navigate to the `AdminDashboardApi` directory.
2. Execute the following commands:

```bash
dotnet restore
dotnet build
dotnet run
