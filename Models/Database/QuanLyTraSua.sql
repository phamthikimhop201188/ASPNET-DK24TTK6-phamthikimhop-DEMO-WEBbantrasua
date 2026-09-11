SQL
CREATE DATABASE QuanLyBanTraSua;
GO
USE QuanLyBanTraSua;
GO

-- Bảng Danh mục món
CREATE TABLE Category (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(100) NOT NULL
);

-- Bảng Sản phẩm Trà sữa
CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(150) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    Price DECIMAL(18,2) NOT NULL,
    Image NVARCHAR(255),
    Description NVARCHAR(MAX)
);

-- Bảng Đơn đặt hàng
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerName NVARCHAR(100),
    Phone VARCHAR(15),
    Address NVARCHAR(255),
    TotalAmount DECIMAL(18,2),
    OrderDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) DEFAULT N'Chờ xử lý'
);
