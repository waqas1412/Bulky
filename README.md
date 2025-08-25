# 📚 Bulky - ASP.NET Core MVC Bookstore Management System

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-green.svg)](https://dotnet.microsoft.com/apps/aspnet)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-8.0-orange.svg)](https://docs.microsoft.com/en-us/ef/)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A modern, scalable bookstore management system built with ASP.NET Core MVC, featuring a clean architecture with repository pattern, Entity Framework Core, and a responsive Bootstrap UI.

## ✨ Features

- **📖 Category Management**: Full CRUD operations for book categories
- **🏗️ Clean Architecture**: Separation of concerns with layered architecture
- **🗄️ Repository Pattern**: Abstraction layer for data access
- **🎨 Modern UI**: Responsive design with Bootstrap 5 and custom styling
- **✅ Form Validation**: Client and server-side validation
- **🔔 Toast Notifications**: User-friendly success/error messages
- **📱 Mobile Responsive**: Optimized for all device sizes

## 🏗️ Architecture

```
Bulky/
├── 📁 BulkyWeb/                 # Main MVC Web Application
│   ├── 📁 Controllers/          # MVC Controllers
│   ├── 📁 Views/               # Razor Views
│   ├── 📁 wwwroot/            # Static Files (CSS, JS, Images)
│   └── Program.cs             # Application Entry Point
├── 📁 Bulky.DataAccess/        # Data Access Layer
│   ├── 📁 Data/               # DbContext and Migrations
│   ├── 📁 Repository/         # Repository Pattern Implementation
│   └── 📁 Migrations/         # Entity Framework Migrations
├── 📁 Bulky.Models/            # Domain Models
└── 📁 Bulky.Utility/           # Utility Classes and Constants
```

## 🚀 Technology Stack

- **Backend**: ASP.NET Core 8.0 MVC
- **Database**: SQL Server with Entity Framework Core 8.0
- **Frontend**: Bootstrap 5, jQuery, Toastr.js
- **Architecture**: Repository Pattern, Dependency Injection
- **Validation**: Data Annotations, Client-side validation

## 📋 Prerequisites

Before running this application, make sure you have the following installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB or Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

## 🛠️ Installation & Setup

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/Bulky.git
cd Bulky
```

### 2. Database Setup

1. **Update Connection String** in `BulkyWeb/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=Bulky;Trusted_Connection=true;TrustServerCertificate=true"
  }
}
```

2. **Run Entity Framework Migrations**:
```bash
cd BulkyWeb
dotnet ef database update
```

### 3. Run the Application

```bash
cd BulkyWeb
dotnet run
```

The application will be available at:
- **HTTP**: http://localhost:5022
- **HTTPS**: https://localhost:7031

## 📖 Usage

### Category Management

1. **View Categories**: Navigate to `/Category` to see all categories
2. **Create Category**: Click "Create New Category" and fill in the form
3. **Edit Category**: Click the "Edit" button next to any category
4. **Delete Category**: Click the "Delete" button and confirm

### Features Overview

- **Responsive Design**: Works seamlessly on desktop, tablet, and mobile
- **Real-time Validation**: Instant feedback on form inputs
- **Toast Notifications**: Success and error messages with smooth animations
- **Bootstrap Icons**: Modern iconography throughout the interface

## 🏛️ Project Structure

### Models (`Bulky.Models/`)
- `Category.cs` - Category entity with validation attributes
- `ErrorViewModel.cs` - Error handling model

### Data Access (`Bulky.DataAccess/`)
- `ApplicationDbContext.cs` - Entity Framework DbContext
- Repository pattern implementation with generic and specific repositories
- Entity Framework migrations for database schema management

### Web Application (`BulkyWeb/`)
- MVC controllers with dependency injection
- Razor views with Bootstrap styling
- Static files (CSS, JavaScript, images)

## 🔧 Configuration

### Database Configuration
The application uses Entity Framework Core with SQL Server. The connection string is configured in `appsettings.json`.

### Dependency Injection
Services are registered in `Program.cs`:
- `ApplicationDbContext` - Database context
- `ICategoryRepository` - Category repository interface
- `CategoryRepository` - Category repository implementation

## 🎨 UI/UX Features

- **Modern Design**: Clean, professional interface with custom color scheme
- **Responsive Layout**: Bootstrap 5 grid system for mobile-first design
- **Interactive Elements**: Hover effects, smooth transitions, and animations
- **Accessibility**: Semantic HTML and ARIA attributes
- **Toast Notifications**: Non-intrusive success/error feedback

## 🧪 Testing

To run tests (if implemented):

```bash
dotnet test
```

## 📦 Deployment

### Local Development
```bash
dotnet run --environment Development
```

### Production
```bash
dotnet publish -c Release
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/)
- [Bootstrap](https://getbootstrap.com/)
- [Toastr.js](https://github.com/CodeSeven/toastr)

## 📞 Support

If you have any questions or need help, please:

- 📧 Open an [Issue](https://github.com/yourusername/Bulky/issues)
- 💬 Start a [Discussion](https://github.com/yourusername/Bulky/discussions)
- 📖 Check the [Documentation](https://docs.microsoft.com/en-us/aspnet/core/)

---

<div align="center">
  <p>Made with ❤️ using ASP.NET Core</p>
  <p>
    <a href="https://github.com/yourusername/Bulky/stargazers">
      <img src="https://img.shields.io/github/stars/yourusername/Bulky" alt="Stars">
    </a>
    <a href="https://github.com/yourusername/Bulky/network">
      <img src="https://img.shields.io/github/forks/yourusername/Bulky" alt="Forks">
    </a>
    <a href="https://github.com/yourusername/Bulky/issues">
      <img src="https://img.shields.io/github/issues/yourusername/Bulky" alt="Issues">
    </a>
  </p>
</div>
