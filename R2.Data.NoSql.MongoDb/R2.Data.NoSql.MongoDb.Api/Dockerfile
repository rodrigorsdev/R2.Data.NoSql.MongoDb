FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY R2.Data.NoSql.MongoDb.Api/R2.Data.NoSql.MongoDb.Api.csproj R2.Data.NoSql.MongoDb.Api/
RUN dotnet restore R2.Data.NoSql.MongoDb.Api/R2.Data.NoSql.MongoDb.Api.csproj
COPY . .
WORKDIR /src/R2.Data.NoSql.MongoDb.Api
RUN dotnet build R2.Data.NoSql.MongoDb.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish R2.Data.NoSql.MongoDb.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "R2.Data.NoSql.MongoDb.Api.dll"]
