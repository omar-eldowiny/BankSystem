# BankSystem
# OOP Practice: Bank & Employee Systems

A console application built with **C#** to practically demonstrate the core pillars of Object-Oriented Programming (OOP). 

## 🎯 Project Overview
This repository contains two mini-projects designed to apply OOP concepts in real-world scenarios:
1. **Bank Account System:** Simulates different types of bank accounts (Standard, Savings, Checking) with specific deposit, withdrawal, and interest logic.
2. **Employee Management System:** Manages different employee roles (Manager, Developer, Tester) with custom salary calculations and information display.

## 🛠️ Key OOP Concepts Applied

* **Encapsulation:** * Secured sensitive data (e.g., `_balance`, `salary`) using `private` fields.
    * Implemented validation rules inside `public` properties (e.g., preventing negative interest rates or invalid experience years).
* **Inheritance:** * Created base classes (`BankAccount`, `Employee`) to share common properties and methods.
    * Derived specific classes (`SavingsAccount`, `Manager`, `Developer`) to extend functionality without code duplication.
* **Polymorphism:** * Utilized `virtual` and `override` keywords to customize methods in derived classes.
    * Applied the `base` keyword to elegantly invoke parent class constructors and methods (e.g., merging withdrawal fees with the requested amount before calling the base withdrawal logic).

## Technologies Used
* C#
