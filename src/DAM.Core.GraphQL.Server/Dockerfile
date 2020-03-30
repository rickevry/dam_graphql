FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as sdk


FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine as runtime
WORKDIR /app


COPY ./bin/Release/netcoreapp3.1/publish/ /app

# 9110 - Petabridge.Cmd
# 5055 - Akka.Cluster
EXPOSE 44342 80

# Needed because https://stackoverflow.com/questions/51977474/install-dotnet-core-tool-dockerfile
ENV PATH="${PATH}:/root/.dotnet/tools"


ENTRYPOINT ["dotnet", "DAM.Core.GraphQL.Server.dll"]