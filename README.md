## A Book Review web app

This is an example web app in which the same features are implemented as those required for the CS296N lab assignments.

## 

## Branches

### 0-Baseline

Code from CS295N which we are building on in CS296N

### 1-Validation

Demonstrates using validation attributes to control validation in the browser, controller, and database.

### 2-IdentityDemo

Demonstrates adding packages and code to support ASP.NET Identity

### 3-AuthenticationDemo

Added regristration and login features.

### 4-AuthorizationDemo

Added admin features and restriction of controllers and methods based on Identity role.

### 5-AsyncDemo

Changed all controller methods that access the database and associated methods to async.

### 6-Performance

Added a folder with JMeter tests and test results.

### 7-ComplexDomain

Added a comment class to the domain model along with associated view and controller methods.

### 7-MoreComplexDomain

Added a more complex domain model with Book and Author models in addition to Review, Comment and AppUser.

------

### 

### SQLiteMigrations

*This branch was merged into the 5-AsyncDemo branch so subsequent branches have the additional migrations project.*
 This version has a separate project for SQLite migrations. BookReviews is the startup project and contains SQL Server migrations. EF commands that target SQLite migrations are written like this:

- dotnet core CLI (Run from the BookReview project folder):
  - `dotnet ef migrations add NewMigration --project ../SQLiteMigrations`
  - `dotnet ef migrations script --project ../SQLiteMigrations`
- package manager console:
  - `add-migration NewMigration -project SQLiteMigrations`
  - `script-migration -project SQLiteMigrations`

**Note:** You may need to explicitly build  the SQLiteMigrations project after adding a migration so that the new  migration is copied to the BookReviews project (it is included in the  .dll that is output to the bin folder).

The SQLiteMigrations project was created following this tutorial: [Using a Separate Migrations Project](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=vs) Note: In the BookReviews project, I did not add a reference to the SQLiteMigrations project. I changed the BaseOutputPath of SQLiteMigrations to that of BookReviews instead.
