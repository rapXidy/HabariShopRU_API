# HabariShopRU_API

- Clone the repo to your local machine
- Open with any IDE of your choice
- Install the necessary C# and .net plugins to enable you run a .net project locally

# Customer API

A .NET Core API project for managing customer data with MsSQL as the database. This API allows for creating, reading, updating, and deleting customer records.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Running Tests](#running-tests)
- [Contributing](#contributing)
- [License](#license)

## Introduction

This project is a RESTful API built with .NET Core and Dapper, utilizing PostgreSQL for data storage. It provides endpoints to manage customer information, including creating, reading, updating, and deleting customer records.

## Features

- RESTful API endpoints for CRUD operations on customer data
- Integration with PostgreSQL
- Asynchronous operations
- Unit tests with xUnit and Moq

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- [MsSQL](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. *Clone the repository:*

    bash
    git clone https://github.com/yourusername/customer-api.git
    cd customer-api
    

2. *Set up MsSQL:*

    Ensure MsSQL is installed and running. Create a database for the project:

    sql
    CREATE DATABASE HabariShopRU_db;
    

3. *Update connection string:*

    Update the connection string in appsettings.json with your PostgreSQL database details:

    json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Host=localhost;Database=HabariShopRU_db;Username=yourusername;Password=yourpassword"
      }
    }
    

4. *Restore dependencies and build the project:*

    bash
    dotnet restore
    dotnet build
    

5. *Apply migrations and update the database:*

    bash
    dotnet ef database update
    

## Usage

1. *Run the application:*

    bash
    dotnet run
    

2. *Access the API:*

    The API will be available at https://localhost:5001 or http://localhost:5000.

## API Endpoints

- *GET /api/customers*: Retrieve all customers
- *GET /api/customers/{id}*: Retrieve a specific customer by ID
- *POST /api/customers*: Create a new customer
- *PUT /api/customers/{id}*: Update an existing customer by ID
- *DELETE /api/customers/{id}*: Delete a customer by ID

### Example Request

*GET /api/customers*

```bash
curl -X GET "https://localhost:5001/api/customers" -H "accept: text/plain"

### Explanation

- *Introduction*: A brief overview of the project.
- *Features*: Highlights key features of the project.
- *Prerequisites*: Lists the necessary tools and technologies required.
- *Installation*: Step-by-step instructions to set up the project.
- *Usage*: Instructions on how to run the application.
- *API Endpoints*: Lists available API endpoints with example requests.
- *Running Tests*: Describes how to run the unit tests.
- *Contributing*: Guidelines for contributing to the project.
- *License*: Information about the project's license. 

This README.md provides a comprehensive guide to understanding, setting up, and contributing to the project. Adjust the content to fit the specifics of your project. 
