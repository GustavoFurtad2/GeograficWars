FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY GeograficWars.csproj .
RUN dotnet restore GeograficWars.csproj

COPY . .
RUN dotnet build GeograficWars.csproj -c Release -o /app/build

RUN dotnet publish GeograficWars.csproj -c Release -o /app/publish

FROM nginx:alpine
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]