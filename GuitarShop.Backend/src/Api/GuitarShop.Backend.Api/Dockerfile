#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Api/GuitarShop.Backend.Api/GuitarShop.Backend.Api.csproj", "src/Api/GuitarShop.Backend.Api/"]
COPY ["src/Application/GuitarShop.Backend.Application/GuitarShop.Backend.Application.csproj", "src/Application/GuitarShop.Backend.Application/"]
COPY ["src/Dal/GuitarShop.Backend.Dal/GuitarShop.Backend.Dal.csproj", "src/Dal/GuitarShop.Backend.Dal/"]
COPY ["src/Domain/GuitarShop.Backend.Domain/GuitarShop.Backend.Domain.csproj", "src/Domain/GuitarShop.Backend.Domain/"]
RUN dotnet restore "src/Api/GuitarShop.Backend.Api/GuitarShop.Backend.Api.csproj"
COPY . .
WORKDIR "/src/src/Api/GuitarShop.Backend.Api"
RUN dotnet build "GuitarShop.Backend.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GuitarShop.Backend.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GuitarShop.Backend.Api.dll"]
