FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/vanson.Web.Host/vanson.Web.Host.csproj", "src/vanson.Web.Host/"]
COPY ["src/vanson.Web.Core/vanson.Web.Core.csproj", "src/vanson.Web.Core/"]
COPY ["src/vanson.Application/vanson.Application.csproj", "src/vanson.Application/"]
COPY ["src/vanson.Core/vanson.Core.csproj", "src/vanson.Core/"]
COPY ["src/vanson.EntityFrameworkCore/vanson.EntityFrameworkCore.csproj", "src/vanson.EntityFrameworkCore/"]
WORKDIR "/src/src/vanson.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/vanson.Web.Host", "src/vanson.Web.Host"]
COPY ["src/vanson.Web.Core", "src/vanson.Web.Core"]
COPY ["src/vanson.Application", "src/vanson.Application"]
COPY ["src/vanson.Core", "src/vanson.Core"]
COPY ["src/vanson.EntityFrameworkCore", "src/vanson.EntityFrameworkCore"]
WORKDIR "/src/src/vanson.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "vanson.Web.Host.dll"]
