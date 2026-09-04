# Acceptance Criteria – Game Currency Sale

| ID | Requirement | Acceptance Criteria |
|---|---|---|
| AC1 | View packages | When the program starts, it shows at least 3 currency packages. |
| AC2 | Select package | A valid package number selects the correct package. |
| AC3 | Quantity | A quantity greater than 0 is accepted. |
| AC4 | Total price | The total equals package price multiplied by quantity. |
| AC5 | Customer name | The customer's name is shown in the final sale summary. |
| AC6 | Invalid input | Invalid package numbers are rejected with a message. |
| AC7 | Sale summary | The final screen shows package, quantity, and total price. |

## Example Test

Input:
- Customer: Alex
- Package: 2
- Quantity: 3

Expected:
- Package: 1000 Coins
- Price: $4.99 each
- Total: $14.97
