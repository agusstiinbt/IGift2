var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<IGiftDataBaseSettings>(
    builder.Configuration.GetSection("IGiftDataBase"));

builder.Services.AddSingleton<IChatService2, ChatService2>();

builder.Services.AddTransient(typeof(INonAuditableMongoDbUnitOfWork<,>), typeof(NonAuditableMongoDbUnitOfWork<,>));
builder.Services.AddTransient(typeof(INonAuditableMongoDbRepository<,>), typeof(NonAuditableRepository<,>));

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
