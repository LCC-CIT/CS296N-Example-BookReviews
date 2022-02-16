# CS296N Example
## A Book Review web app
This is an example web app in which the same features are implemented as those required for the CS296N lab assignments.

## SQLiteMigrations branch
This version has a separate project for SQLite migrations.
BookReviews is the startup project and contains SQL Server migrations.
EF commands that target SQLite migrations are written like this:
- dotnet core CLI (Run from the BookReview project folder):
  - `dotnet ef migrations add NewMigration --project ../SQLiteMigrations`
  - `dotnet ef migrations script --project ../SQLiteMigrations`
- package manager console:
  - `add-migration NewMigration -project SQLiteMigrations`
  - `script-migration -project SQLiteMigrations`

The SQLiteMigrations project was created following this tutorial:
[Using a Separate Migrations Project](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=vs)
Note: In the BookReviews project, I did not add a reference to the SQLiteMigrations project.
I changed the BaseOutputPath of SQLiteMigrations to that of BookReviews instead.