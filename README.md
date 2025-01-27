# StokTakip - Inventory Management System

## Project Overview

A web-based product and category management system built with ASP.NET Core.

### 🔗 Project Repository

https://github.com/semihorhanbio/DBFirstProje.Web

### 👨‍💻 Developer

Semih Orhan

## 🎯 Purpose and Benefits

This project enables product and category management through a web interface. Users can view, add, and update product details such as price, stock, size, color, description, and manage categories with their properties.

### Key Benefits

- **Centralized Management**: Single admin panel for product and category management
- **Quick Access**: Fast access to stock, price, and category information
- **Easy Maintenance**: Structured database operations using EF Core and .NET
- **Scalability**: Easy to add new features and modify existing ones

## 🛠️ Technologies Used

- **ASP.NET Core (.NET 6)**: Main framework
- **C#**: Primary programming language
- **Entity Framework Core**: ORM tool for database operations
- **SQL Server**: Database
- **HTML/CSS/Bootstrap**: Frontend development

## 🏗️ Project Structure

### Product Model Features

- Product name
- Price
- Stock quantity
- Image URL
- Optional properties:
  - Color
  - Width
  - Height
  - Description

### Category Model Features

- Category name
- Description
- Subcategory support (SubCategory1, SubCategory2, etc.)

## 📱 Pages and Functionality

### Main Pages

1. **Home Page (Home/Index)**

   - Project welcome page
   - General site overview

2. **Products Page (Product/Index)**

   - Product listing
   - CRUD operations for products
   - Product management interface

3. **Categories Page**

   - Category listing and management
   - Subcategory display
   - Category descriptions

4. **Contact/About**
   - Static information pages

## 🚀 Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server
- Visual Studio (recommended) or VS Code

### Installation

1. Clone the repository

```bash
git clone https://github.com/semihorhanbio/DBFirstProje.Web
```

2. Update database connection string in `appsettings.json`
3. Run database migrations

```bash
dotnet ef database update
```

4. Run the application

```bash
dotnet run
```

### 📝 Contributing

Contributions, issues, and feature requests are welcome!

### 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
