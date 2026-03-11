FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

ARG PROJECT_PATH=HospitalBomCodigo/HospitalBomCodigo.csproj
COPY . .

RUN dotnet restore "${PROJECT_PATH}"
RUN dotnet publish "${PROJECT_PATH}" -c Release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS runtime
WORKDIR /app
COPY --from=build /app .


ENTRYPOINT ["dotnet", "HospitalBomCodigo.dll"]
