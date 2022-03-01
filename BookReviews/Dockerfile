# download the ASP.NET Core runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
# Copy files from the dev machine to the container.
COPY BookReviews/bin/Release/netcoreapp3.1/publish/ app/
# Change directories, we need to run the app from the app directory.
WORKDIR app/
# Ports for the app to listen in inside the container (http and https)
EXPOSE 80
EXPOSE 443
# Start the web app when the container runs.
ENTRYPOINT ["dotnet", "BookReviews.dll"]