var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors(builder =>
{
    builder
        .WithOrigins("*") // מוגדר את המקורות שמורשים לבצע בקשות CORS
        .AllowAnyMethod() // מאפשר בקשות מכל סוג של שיטה (GET, POST, וכדומה)
        .AllowAnyHeader(); // מאפשר בקשות עם כל סוגי הכותרות
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// הוספת תמיכה ב-CORS
app.UseCors("AllowAll");

app.MapControllers();

app.Run();
