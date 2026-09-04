# Database Design – Game Currency Sale

## ERD (Simple)

Customer (1) ---- (Many) Sale (Many) ---- (1) CurrencyPackage

## Tables

### Customer
| Field | Type | Key |
|---|---|---|
| CustomerId | INTEGER | PK |
| Name | TEXT | |

### CurrencyPackage
| Field | Type | Key |
|---|---|---|
| PackageId | INTEGER | PK |
| PackageName | TEXT | |
| Coins | INTEGER | |
| Price | REAL | |

### Sale
| Field | Type | Key |
|---|---|---|
| SaleId | INTEGER | PK |
| CustomerId | INTEGER | FK |
| PackageId | INTEGER | FK |
| Quantity | INTEGER | |
| TotalPrice | REAL | |

## Relationship
- One customer can make many sales.
- One currency package can appear in many sales.
- Each sale belongs to one customer and one currency package.
