var builder = WebApplication.CreateBuilder(args);
<<<<<<< HEAD
//Ion ssdf
=======
// sophus was here twice
>>>>>>> a7df5ab8263cdd411d3573795038ba8a501ddd01
// Add services to the container.
// sophus was here
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
