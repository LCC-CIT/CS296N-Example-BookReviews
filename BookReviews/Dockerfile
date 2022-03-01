# download the ASP.NET Core runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
# Copy files from the dev machine to the container.
COPY BookReviews/bin/Release/netcoreapp3.1/publish/ app/
# Change directories, we need to run the app from the app directory.
WORKDIR app/
EXPOSE 80
# Start the web app when the container runs.
ENTRYPOINT ["dotnet", "BookReviews.dll"]