FROM microsoft/dotnet:2.1-sdk as build  
WORKDIR /PatternAppObserve
COPY PatternAppObserve . 

RUN dotnet restore
RUN dotnet publish "PatternAppObserve.csproj" -c Release -o /app

FROM microsoft/dotnet:2.1-runtime as deployment
WORKDIR /app 
COPY --from=build /app .
ENTRYPOINT [ "dotnet", "PatternAppObserve.dll" ]