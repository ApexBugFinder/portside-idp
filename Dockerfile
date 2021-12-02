FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base


WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80;https://+:443

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster AS build
WORKDIR /src
COPY ["IDP.csproj", "./"]
RUN dotnet restore "IDP.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "IDP.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IDP.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IDP.dll", "seed"]
