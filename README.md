# CS296N Example
## A Book Review web app
This is an example web app in which the same features are implemented as those required for the CS296N lab assignments.

## SQLiteMigrations branch
This version has a separate project for SQLite migrations.
BookReviews is the startup project and contains SQL Server migrations.
EF commands that target SQLite migrations are written like this:
- dotnet core CLI:<br/>
  `dotnet ef migrations add NewMigration --project SQLiteMigrations`
- package manager console:<br/>
  `Add-Migration NewMigration -Project SQLiteMigrations`

The migrations project was created following this tutorial:
[Using a Separate Migrations Project](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=vs)
Note: In the BookReviews project, I did not add a reference to the SQLiteMigrations project.
I changed the BaseOutputPath of SQLiteMigrations to that of BookReviews instead.