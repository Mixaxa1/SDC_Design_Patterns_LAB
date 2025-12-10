using Newtonsoft.Json;
using Task2v2.Db;
using Task2v2.Db.Entities;
using Task2v2.SecondController;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddTransient<ISecondApiOperations, SecondApiOperations>();
builder.Services.AddTransient<IFirstApiOperations, FirstControllerProxy>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.UseSwagger();

    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

var context = new AppDbContext();

context.Database.EnsureCreated();

app.Run();


/*var route1 = "https://localhost:7167/" + "FirstApi/";
var route2 = "https://localhost:7167/" + "SecondApi/";


var client = new HttpClient();

var responce = await client.GetAsync(route1);
var content = await responce.Content.ReadAsStringAsync();

var resultList = JsonConvert.DeserializeObject<List<SomeEntity?>>(content);

var imgEnt = new SomeImageEntity
{
    ImageUrl = "testUri",
    SomeEntity = resultList[0]
};

responce = await client.PostAsJsonAsync(new Uri(route2), imgEnt);
content = await responce.Content.ReadAsStringAsync();

var resultImgEnt = JsonConvert.DeserializeObject<SomeImageEntity?>(content);

responce = await client.GetAsync(new Uri(route2) + $"img/{resultImgEnt.Id}");
content = await responce.Content.ReadAsStringAsync();

Console.WriteLine(content);
*/