# Products Management API

## Overview

Products Management API is a RESTful Web API built using ASP.NET Core for managing product records. The project demonstrates the implementation of a layered architecture, clean separation of concerns, and standard REST principles.

The API allows clients to create, retrieve, update, search, and delete products while interacting with a SQL Server database.

---

## Features

* Retrieve all products
* Retrieve a product by its ID
* Search products by name
* Add new products
* Update existing products
* Delete products
* Proper HTTP status code handling
* DTO-based data transfer
* Layered architecture design

---

## Technologies Used

* ASP.NET Core Web API
* C#
* SQL Server
* ADO.NET
* RESTful API Design
* DTO (Data Transfer Object) Pattern
* Git & GitHub

---

## Project Architecture

The project follows a 3-Tier Architecture:

### Presentation Layer

Responsible for handling HTTP requests and returning HTTP responses through API Controllers.

### Business Layer

Contains business logic and acts as an intermediary between the API layer and the data access layer.

### Data Access Layer

Responsible for database communication and executing SQL operations.

---

## API Endpoints

### Get All Products

GET

/api/products/All

Returns a list of all products.

---

### Get Product By ID

GET

/api/products/{id}

Returns a single product by its identifier.

---

### Search Products

GET

/api/products/search?name=value

Searches for products using a product name.

---

### Add New Product

POST

/api/products/AddNew

Creates a new product record.

---

### Update Product

PUT

/api/products/Update

Updates an existing product.

---

### Delete Product

DELETE

/api/products/{id}

Deletes a product by its identifier.

---

## Sample Product Model

```json
{
  "id": 1,
  "productName": "Laptop",
  "price": 1200,
  "quantity": 10,
  "tax": 16,
  "createdAt": "2026-06-24T12:00:00"
}
```

## 📸 Screenshots

---

### 🔹 Swagger (API Documentation)

#### Get Info
<img src="images/GetInfo Swager.jpeg" width="900">

*Get detailed product information via Swagger API endpoint.*

---

#### Search
<img src="images/search swager.jpeg" width="900">

*Search for products using Swagger testing interface.*

---

#### Full Swagger Overview
<img src="images/swager full.png" width="900">

*Complete API documentation showing all available endpoints.*

---

### 🖥️ Win Forms - Add / Update

#### Add Product
<img src="images/add win form.jpeg" width="900">

*Form used to add a new product into the system.*

---

#### Update Product
<img src="images/update win form.jpeg" width="900">

*Allows editing and updating existing product details.*

---

### 🔍 Search Features

#### Search for product 1
<img src="images/search win form 1.png" width="900">

*Basic search interface for filtering products.*

---

#### Search for product 2
<img src="images/search win form 2.png" width="900">

*Selected product info was filled.*

---

### 🗑️ Delete Features

#### Delete product 1
<img src="images/delete win form.jpeg" width="900">

*Interface for deleting selected products.*

---

#### Delete product 2
<img src="images/delete win form 2.jpeg" width="900">

*Confirmation and deletion workflow for product removal.*

---


## Learning Objectives

This project was built to practice and strengthen knowledge in:

* ASP.NET Core Web API Development
* RESTful API Design
* Layered Architecture
* DTO Implementation
* SQL Server Integration
* CRUD Operations
* HTTP Status Codes
* Software Design Principles

---

## Future Improvements

* Dependency Injection
* Repository Pattern
* Entity Framework Core
* Authentication & Authorization
* Pagination
* Global Exception Handling
* Logging
* Unit Testing

---

## Author

Alaa

Software Engineering Graduate | .NET Developer

Focused on Backend Development using C#, ASP.NET Core, SQL Server, and Software Engineering Principles.
