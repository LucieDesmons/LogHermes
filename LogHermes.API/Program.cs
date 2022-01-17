using Microsoft.EntityFrameworkCore;
using Stock.BL;
using Stock.DAL;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<DBLogHermesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Lucie")));
builder.Services.AddControllers();
builder.Services.AddDbContext<DBLogHermesContext>();
builder.Services.AddTransient<UtilisateurService>();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "LogHermes", Version = "v1.0" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LogHermes API v1.0"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();