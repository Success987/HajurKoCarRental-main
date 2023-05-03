FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./*.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Debug -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

RUN apt-get update && \
    apt-get install -y curl && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/*

# Install SurrealDB
COPY ./install.sh /app/install.sh
RUN chmod +x /app/install.sh && \
    /app/install.sh --accept-license && \
    rm /app/install.sh

# Set the SurrealDB connection string
ENV ConnectionStrings__SurrealDBConnection="Server=localhost;Port=2345;Username=surreal;Password=surreal;Database=surrealdb"

# Start the SurrealDB server and the application
CMD ["sh", "-c", "/usr/local/bin/surreal start && dotnet HajurKoCarRental.dll"]
