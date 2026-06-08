var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<WebApplication1.Models.DataContext>();

// 'הזרקת הסרביס עבור הממשק של הקטגוריות, הרכיבים והמכונים
builder.Services.AddScoped<WebApplication1.interfaces.ICategoryService, WebApplication1.Services.CategoryService>();
builder.Services.AddScoped<WebApplication1.interfaces.IIngredientService, WebApplication1.Services.IngredientService>();
builder.Services.AddScoped<WebApplication1.interfaces.IRecipeService, WebApplication1.Services.RecipeService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
