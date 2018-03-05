FROM microsoft/aspnetcore:2.0

ARG source
WORKDIR /app
EXPOSE 80

COPY Newsstat-ASP.NET/drop/WebApplication1 .
ENTRYPOINT ["dotnet", "WebApplication1.dll"]