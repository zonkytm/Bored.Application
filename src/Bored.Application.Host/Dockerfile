#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Bored.Application.Host/Bored.Application.Host.csproj", "src/Bored.Application.Host/"]
COPY ["src/Bored.Application.Api/Bored.Application.Api.csproj", "src/Bored.Application.Api/"]
COPY ["src/Bored.Application.AppServices.Contracts/Bored.Application.AppServices.Contracts.csproj", "src/Bored.Application.AppServices.Contracts/"]
COPY ["src/Bored.Application.AppServices/Bored.Application.AppServices.csproj", "src/Bored.Application.AppServices/"]
RUN dotnet restore "./src/Bored.Application.Host/Bored.Application.Host.csproj"
COPY . .
WORKDIR "/src/src/Bored.Application.Host"
RUN dotnet build "./Bored.Application.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Bored.Application.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bored.Application.Host.dll"]