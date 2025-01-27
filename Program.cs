var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddHttpsRedirection(options =>
//{
//    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect; 
//    options.HttpsPort = 443;
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
{
    policy.AllowAnyOrigin() 
          .AllowAnyHeader()
          .AllowAnyMethod();
});

//app.UseHttpsRedirection(); 
app.UseAuthorization();
app.MapControllers();
app.Run();