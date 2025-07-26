
# 🏦 BankingApp

A simple C# console-based banking system that simulates core banking functionalities like user account management, deposits, withdrawals, transaction logs, top account rankings, and fixed deposit calculations.

---

## 📁 Project Structure

```
BankingApp/
│
├── Models/
│   ├── Users.cs
│   ├── UserAccount.cs
│   ├── ChildAccount.cs
│   ├── IServicable.cs
│
├── Services/
│   ├── IBankService.cs
│   ├── BankService.cs
│
├── Program.cs
└── README.md
```

---

## 🧑‍💼 Features

* ✅ Create and manage user and child accounts
* 💵 Deposit and withdraw money
* 📄 View transaction history
* 📊 Display top 5 users by balance
* 🔍 Search for users
* 📈 Calculate Fixed Deposit maturity amount

---

## 🚀 Getting Started

### Prerequisites

* [.NET 6.0 SDK or later](https://dotnet.microsoft.com/download)
* C# compatible IDE (like Visual Studio / Visual Studio Code)

### Running the App

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/BankingApp.git
   cd BankingApp
   ```

2. **Build and run**:

   ```bash
   dotnet build
   dotnet run
   ```

---

## 🧩 Class Overview

### `Users` (Abstract Base Class)

* Properties: `Id`, `Name`, `Email`, `AccountNumber`, `Amount`, `transaction`
* Methods: `Display()`, `ShowTransaction()`

### `UserAccount` / `ChildAccount`

* Inherits from `Users` and implements `IServicable`
* Additional properties (in `ChildAccount`): `FatherName`, `FatherContact`
* Implements: `Deposit(int amt)`, `Withdraw(int amt)`

### `IServicable` (Interface)

* Contract for deposit and withdrawal services

### `BankService` (Implements `IBankService`)

* `DisplayAll()`: Lists all user accounts
* `DisplayTop5()`: Shows top 5 accounts by balance
* `SearchUser()`: Checks if a user exists
* `CalculateFD()`: Computes FD maturity amount

---

##  Output
```
Lokesh: Account Created Successfully!

Ram: Account Created Successfully!

Priya: Account Created Successfully!

Praveen: Account Created Successfully!

Krishna: Account Created Successfully!

Rajeshxx: Account Created Successfully!

Yuvan: Account Created Successfully!

Dear Yuvan: 87 Rupees Deposited Successfully
Current Balance: 87

Account Holder Name: Yuvan
Account Number: 12345684
Email: yuvii@gmail.com
Balance: 87

Dear Lokesh: 1000 Rupees Deposited Successfully
Current Balance: 1000

Dear Ram: 8000 Rupees Deposited Successfully
Current Balance: 8000

Dear Priya: 8999 Rupees Deposited Successfully
Current Balance: 8999

Dear Praveen: 999 Rupees Deposited Successfully
Current Balance: 999

Dear Krishna: 7999 Rupees Deposited Successfully
Current Balance: 7999

Dear Ram: 1000 Rupees Withdrawn Successfully
Current Balance: 7000

Insufficient balance

Displaying Lokesh's Transactions:
Lokesh: Account Created Successfully!
1000 Rupees Deposited Successfully

Displaying All Bank Users:
----------------------------------------------------------------------------------------
Name                      Account Number       Email                             Balance
-----------------------------------------------------------------------------------------
Lokesh                    12345678             loki@gmail.com                       1000
Ram                       12345679             ram@gmail.com                        7000
Priya                     12345680             priya@gmail.com                      8999
Praveen                   12345681             praveen@gmail.com                     999
Krishna                   12345682             krishna@gmail.com                    7999
Rajeshxx                  12345683             rajeshxx@gmail.com                      0

Displaying Top 5 Bank Users:
Name: Priya | Balance: 8999
Name: Krishna | Balance: 7999
Name: Ram | Balance: 7000
Name: Lokesh | Balance: 1000
Name: Praveen | Balance: 999

Searching for Users:
User already exists: Ram

User does not exist: Tharun


Calculating Fixed Deposit
Amount: 100000
Rate: 7.5
Years: 3
FD Maturity Amount: 124229.68749999999
Lokesh: Account Created Successfully!

Ram: Account Created Successfully!

Priya: Account Created Successfully!

Praveen: Account Created Successfully!

Krishna: Account Created Successfully!

Rajeshxx: Account Created Successfully!

Yuvan: Account Created Successfully!

Dear Yuvan: 87 Rupees Deposited Successfully
Current Balance: 87

Account Holder Name: Yuvan
Account Number: 12345684
Email: yuvii@gmail.com
Balance: 87

Dear Lokesh: 1000 Rupees Deposited Successfully
Current Balance: 1000

Dear Ram: 8000 Rupees Deposited Successfully
Current Balance: 8000

Dear Priya: 8999 Rupees Deposited Successfully
Current Balance: 8999

Dear Praveen: 999 Rupees Deposited Successfully
Current Balance: 999

Dear Krishna: 7999 Rupees Deposited Successfully
Current Balance: 7999

Dear Ram: 1000 Rupees Withdrawn Successfully
Current Balance: 7000

Insufficient balance

Displaying Lokesh's Transactions:
Lokesh: Account Created Successfully!
1000 Rupees Deposited Successfully

Displaying All Bank Users:
----------------------------------------------------------------------------------------
Name                      Account Number       Email                             Balance
-----------------------------------------------------------------------------------------
Lokesh                    12345678             loki@gmail.com                       1000
Ram                       12345679             ram@gmail.com                        7000
Priya                     12345680             priya@gmail.com                      8999
Praveen                   12345681             praveen@gmail.com                     999
Krishna                   12345682             krishna@gmail.com                    7999
Rajeshxx                  12345683             rajeshxx@gmail.com                      0

Displaying Top 5 Bank Users:
Name: Priya | Balance: 8999
Name: Krishna | Balance: 7999
Name: Ram | Balance: 7000
Name: Lokesh | Balance: 1000
Name: Praveen | Balance: 999

Searching for Users:
User already exists: Ram

User does not exist: Tharun


Calculating Fixed Deposit
Amount: 100000
Rate: 7.5
Years: 3
FD Maturity Amount: 124229.68749999999

```




## 🧑‍💻 Author

* **Hari Ram L**


