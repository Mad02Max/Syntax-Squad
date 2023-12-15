# Syntax Squad
# **Table of Contents**
* Features 

* Code structure

* UML

* Classes

* Collaboration 

## Introduction

I'm excited to present our group project – a small-scale bank application developed in C#. Our aim is to create a user-friendly and efficient system that facilitates basic banking operations. Our application will include features such as account creation, fund transfers, balance inquiries,take out a loan and transaction history.

## **Features** 

* Customer login - Access your account with your username and password
  
* Admin: Gain access to specific administrative functionalities
  
* Customer functionalities: Create new accounts - Create a new personalized bank account 

* Transfer: Move money between / to accounts

* Balance inquiry: Check your accounts and balance

* Transaction history: Review your transactions

* Loan request - Request a loan with a set interest rate

#* Admin functionalities:

* User management - create new user accounts 

* Adjust exchange rates

* Full overview of users, loans and transactions made

## **Code Structure**

 The project’s structure is built with the help of Single responsibility (SOLID). Each class has their own responsibility, focusing on one aspect of the application's functionality. For example, we have separate classes for account management, transaction handling, and loans.

## **UML**

## **Classes**

- Loan:This class is responsible for managing all loan-related transactions that users may seek to initiate. 
- CreateAccount:This class has the responsibility for creating any new bank account that the user might want to make.
- Menu: Main Class for the several menus used throughout the application.
- Transfer: This class facilitates the transfer of balances between a user's personal accounts as well as from the user to other accounts.
- Login:A class responsible for managing the authentication process for both customers and administrators.
- User:This is the base for all of the users, both for regular users and admin.
- UserFunctions:Individual user functionalities, such as establishing a transfer limit and modifying one's password.
- AdminFunctions:Class designed to manage administrative functions, including the addition and removal of users, as well as the display of a comprehensive list of all users.
- BankAccounts:Class encapsulates a repository of diverse bank accounts, encompassing account balances and detoning respective currencies in use.
- ExchangeRate:Class that sets a predetermined exchange rate (in our case for SEK, EUR and GBP) and shows these to the user. *

## **Collaboration** 

Thanks to the collective efforts of each team member throughout the project, we hope that you enjoy our application. 
Best regards,
- Mad02Max
- Sim0h
- NoahStener
- Dericay


