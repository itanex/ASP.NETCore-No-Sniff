# Custom Middleware

This project contains middleware to address various needs for security and other needs for ASP.NET Core websites.

## No-Sniff Header Middleware

This middleware applies the No-Sniff header to **ALL** requests handled by the application request pipeline.

### Reference

[Mozilla Docs - No Sniff](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/X-Content-Type-Options)

#### Syntax
> X-Content-Type-Options: nosniff

#### Usage
startup.cs
```cs
using ItxMiddleware.Extensions;
// ...
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    // ...

    app.UseNoSniffMiddleware();

    // ...
}
```