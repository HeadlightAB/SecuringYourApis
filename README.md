# SecuringYourApis
To run this sample, clone and navigate to the solution root folder. 

**Start the IdSrv** and **the PublicMetarApi** projects:
<pre>
...SecuringYourApis> dotnet run --project .\IdSrv\IdSrv.csproj
</pre>
<pre>
...SecuringYourApis> dotnet run --project .\PublicMetarApi\PublicMetarApi.csproj
</pre>

**Get a token** from the IdSrv:
<pre>
> curl -X POST -H "Content-Type: application/x-www-form-urlencoded" -d "grant_type=client_credentials&client_id=weatherTV&client_secret=secret.password.for.weathertv" https://localhost:5001/connect/token
</pre>

Copy the token in the response and send it along with the **request to the protected route/resource** in the PublicMetarApi:
<pre>
> curl https://localhost:6001/api/taf/ESSA -H "Authorization: Bearer eyJhbGciOiJSUz... [cut]" -verbose
</pre>
