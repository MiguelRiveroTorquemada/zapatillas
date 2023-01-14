FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /App

# copy csproj and restore as distinct layers
COPY . ./
RUN dotnet restore

# copy and publish app and libraries

RUN dotnet publish -c Release -o out

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build /App/out . 
ENTRYPOINT ["dotnet", "Zapatillas.dll"]