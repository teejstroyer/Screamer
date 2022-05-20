#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Screamer.WebApi/Screamer.WebApi.csproj", "Screamer.WebApi/"]
COPY ["Screamer.Domain/Screamer.Domain.csproj", "Screamer.Domain/"]
COPY ["Screamer.Infrastructure/Screamer.Infrastructure.csproj", "Screamer.Infrastructure/"]
RUN dotnet restore "Screamer.WebApi/Screamer.WebApi.csproj"
COPY . .
WORKDIR "/src/Screamer.WebApi"
RUN dotnet build "Screamer.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Screamer.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Screamer.WebApi.dll"]
