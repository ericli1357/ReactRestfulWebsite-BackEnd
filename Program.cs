using EmailService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Serialization;
using ReactRestfulWebsite.Data;
using ReactRestfulWebsite.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ReactRestfulWebsiteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
                      });
});

builder.Services.AddSingleton(builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IArticleRepository, ArticleRepository>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHttpsRedirection();
}
app.UseRouting();
app.UseCors();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=SendEmail}"
    );
app.MapControllerRoute(
    name: "category",
    pattern: "{controller=Category}/{action=GetAllCategories}"
    );
app.MapControllerRoute(
    name: "article",
    pattern: "{controller=Article}/{action=GetAllArticles}"
    );

app.Run();
