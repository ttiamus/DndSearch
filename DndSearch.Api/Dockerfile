FROM microsoft/aspnetcore:2.0-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0-nanoserver-1709 AS build
WORKDIR /src
COPY DndSearch.Api/DndSearch.Api.csproj DndSearch.Api/
RUN dotnet restore DndSearch.Api/DndSearch.Api.csproj
COPY . .
WORKDIR /src/DndSearch.Api
RUN dotnet build DndSearch.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DndSearch.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DndSearch.Api.dll"]
