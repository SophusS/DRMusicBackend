var builder = WebApplication.CreateBuilder(args);
var policyName = "_myAllowSpecificOrigins";
//Ion ssdf
// sophus was here twice
// Add services to the container.
// sophus was here
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: policyName,
                      builder =>
                      {
                          builder
                            .WithOrigins("http://localhost:3000") // specifying the allowed origin
                            .WithMethods("GET") // defining the allowed HTTP method
                            .AllowAnyHeader(); // allowing any header to be sent
                      });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
   app.UseSwagger();
    app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
