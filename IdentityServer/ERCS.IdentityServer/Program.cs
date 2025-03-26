using ERCS.IdentityServer.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// IdentityServer setup
builder.Services.AddIdentityServer()
    .AddInMemoryIdentityResources(IdentityResources.GetIdentityResources())
    .AddInMemoryApiScopes(ApiScopes.GetApiScopes())
    .AddInMemoryClients(Clients.GetClients())
    .AddDeveloperSigningCredential();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5007);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();

app.MapControllers();

app.Run();
