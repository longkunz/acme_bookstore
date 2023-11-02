FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
COPY . .
COPY NuGet.Config ./
RUN dotnet publish "/host/Acme.BookStore.HttpApi.Host/Acme.BookStore.HttpApi.Host.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=build /app/publish /app
ENTRYPOINT ["dotnet", "Acme.BookStore.HttpApi.Host.dll"]