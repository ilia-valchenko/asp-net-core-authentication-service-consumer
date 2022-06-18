# asp-net-core-authentication-service-consumer

The service consumer app was developed in order to test the authentication service app: https://github.com/ilia-valchenko/asp-net-core-authentication-service

You will have to use `Authentication` middleware in order to use `[Authorize]` attribute. Go to the Startup.cs and add the following code: `app.UseAuthentication()`.