-- Game Currency Sale Database
CREATE TABLE Customer (
    CustomerId INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL
);

CREATE TABLE CurrencyPackage (
    PackageId INTEGER PRIMARY KEY AUTOINCREMENT,
    PackageName TEXT NOT NULL,
    Coins INTEGER NOT NULL,
    Price REAL NOT NULL
);

CREATE TABLE Sale (
    SaleId INTEGER PRIMARY KEY AUTOINCREMENT,
    CustomerId INTEGER NOT NULL,
    PackageId INTEGER NOT NULL,
    Quantity INTEGER NOT NULL,
    TotalPrice REAL NOT NULL,
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    FOREIGN KEY (PackageId) REFERENCES CurrencyPackage(PackageId)
);

INSERT INTO CurrencyPackage (PackageName, Coins, Price) VALUES
('Starter Pack', 500, 2.99),
('Basic Pack', 1000, 4.99),
('Pro Pack', 2500, 9.99);
