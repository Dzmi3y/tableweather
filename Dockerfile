FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["GetWeatherApi/GetWeatherApi.csproj", "GetWeatherApi/"]
RUN dotnet restore "GetWeatherApi/GetWeatherApi.csproj"
COPY . .
WORKDIR "/src/GetWeatherApi"
RUN dotnet build "GetWeatherApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GetWeatherApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GetWeatherApi.dll"]