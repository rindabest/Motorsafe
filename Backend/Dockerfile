# Sử dụng image .NET SDK 9.0 để build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /App

# Copy csproj và restore các dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy toàn bộ code và build
COPY . ./
RUN dotnet publish -c Release -o out

# Sử dụng image ASP.NET 9.0 để chạy (chỉ chứa runtime)
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /App
COPY --from=build-env /App/out .

# Mở cổng 8080 
EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "MotorSafe.Backend.dll"]
