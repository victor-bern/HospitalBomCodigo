# HospitalBomCodigo — Instruções de execução

# Pré-requisitos
- .NET 10 SDK instalado
- Docker (opcional, para execução em container)
- Visual Studio 2022/2023 ou Visual Studio Code com extensão C# (opcional)

# Executar com .NET CLI

No diretório raiz do repositório:

## Build
dotnet build ./HospitalBomCodigo/HospitalBomCodigo.csproj -c Release

## Executar diretamente pelo projeto
dotnet run --project ./HospitalBomCodigo/HospitalBomCodigo.csproj --configuration Release

## Ou publicar e executar o arquivo DLL gerado
dotnet publish ./HospitalBomCodigo/HospitalBomCodigo.csproj -c Release -o ./publish
dotnet ./publish/HospitalBomCodigo.dll

# Docker

## Construir a imagem 
docker build -t hospitalbomcodigo .

## Executar o container
docker run --rm hospitalbomcodigo

# Executar com IDE

## Visual Studio
- Abra a solução (.sln)
- Clique com o botão direito no projeto HospitalBomCodigo -> "Set as Startup Project"
- Inicie com F5 (debug) ou Ctrl+F5 (sem debug)

## Visual Studio Code
- Abra a pasta do repositório
- Instale a extensão C# (OmniSharp)
- Use o terminal integrado para rodar os comandos dotnet acima ou crie uma configuração em .vscode/launch.json
