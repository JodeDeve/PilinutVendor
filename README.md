# Pilinut Vendor System

A modern ASP.NET Core MVC inventory management system for pilinut product vendors.

## Features

- **Modern UI**: Red-themed interface with gradient accents and smooth animations
- **Inventory Management**: Create, Read, Update, Delete (CRUD) operations for pilinut products
- **Dashboard**: Real-time inventory overview with stock metrics
- **Category Management**: Organize products by Premium and Regular categories
- **Stock Tracking**: Monitor available stock, low stock, and out-of-stock items
- **Product Images**: Upload and display product photos

## Technology Stack

- **Framework**: ASP.NET Core 10.0
- **ORM**: Entity Framework (In-Memory for demo)
- **Frontend**: Bootstrap 5 with custom CSS
- **Real-time Updates**: SignalR
- **Styling**: Modern CSS with red gradient theme

## Color Scheme

- **Primary Red**: #dc2626 (RGB: 220, 38, 38)
- **Dark Red**: #991b1b (RGB: 153, 27, 27)
- **Light Red**: #fef2f2 (RGB: 254, 242, 242)
- **Background**: #f5f7fa

## Running the Application

```bash
dotnet build
dotnet run
```

Then navigate to `https://localhost:5001` in your browser.

## Project Structure

```
PilinutVendorSystem/
├── Controllers/
│   ├── DashboardController.cs
│   ├── InventoryController.cs
│   └── HomeController.cs
├── Models/
│   ├── InventoryItem.cs
│   ├── DashboardViewModel.cs
│   └── ErrorViewModel.cs
├── Services/
│   ├── IInventoryService.cs
│   └── InventoryService.cs
├── Views/
│   ├── Dashboard/
│   ├── Inventory/
│   ├── Home/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   └── js/
└── Program.cs
```

## Features Overview

### Dashboard
- Total product count
- Available stock metrics
- Low stock alerts
- Out of stock items
- Recent product updates

### Inventory Management
- Browse all products
- Filter by Premium/Regular categories
- Add new products with images
- Edit product details
- Delete products
- View detailed product information

## Recent Updates

- ✅ Red theme (replacing green)
- ✅ Modern UI with gradients and shadows
- ✅ Updated for pilinut products
- ✅ Improved form styling
- ✅ Enhanced dashboard metrics
- ✅ Better responsive design

