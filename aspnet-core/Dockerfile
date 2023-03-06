FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/FastFootApp.Web.Host/FastFootApp.Web.Host.csproj", "src/FastFootApp.Web.Host/"]
COPY ["src/FastFootApp.Web.Core/FastFootApp.Web.Core.csproj", "src/FastFootApp.Web.Core/"]
COPY ["src/FastFootApp.Application/FastFootApp.Application.csproj", "src/FastFootApp.Application/"]
COPY ["src/FastFootApp.Core/FastFootApp.Core.csproj", "src/FastFootApp.Core/"]
COPY ["src/FastFootApp.EntityFrameworkCore/FastFootApp.EntityFrameworkCore.csproj", "src/FastFootApp.EntityFrameworkCore/"]
WORKDIR "/src/src/FastFootApp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FastFootApp.Web.Host", "src/FastFootApp.Web.Host"]
COPY ["src/FastFootApp.Web.Core", "src/FastFootApp.Web.Core"]
COPY ["src/FastFootApp.Application", "src/FastFootApp.Application"]
COPY ["src/FastFootApp.Core", "src/FastFootApp.Core"]
COPY ["src/FastFootApp.EntityFrameworkCore", "src/FastFootApp.EntityFrameworkCore"]
WORKDIR "/src/src/FastFootApp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FastFootApp.Web.Host.dll"]
