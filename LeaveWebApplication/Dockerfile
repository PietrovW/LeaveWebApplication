FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 59334
EXPOSE 44382

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["LeaveWebApplication/LeaveWebApplication.csproj", "LeaveWebApplication/"]
RUN dotnet restore "LeaveWebApplication/LeaveWebApplication.csproj"
COPY . .
WORKDIR "/src/LeaveWebApplication"
RUN dotnet build "LeaveWebApplication.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "LeaveWebApplication.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LeaveWebApplication.dll"]