FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

ARG PROJECT_PATH=HospitalBomCodigo/HospitalBomCodigo.csproj
COPY . .

RUN dotnet restore "${PROJECT_PATH}"
RUN dotnet publish "${PROJECT_PATH}" -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS runtime
WORKDIR /app

RUN apt-get update && apt-get install -y tzdata && rm -rf /var/lib/apt/lists/*

ENV TZ=America/Sao_Paulo
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

COPY --from=build /app .

ENTRYPOINT ["dotnet", "HospitalBomCodigo.dll"]