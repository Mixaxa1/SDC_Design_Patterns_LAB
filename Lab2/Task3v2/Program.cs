using Task3v2ApiSide.ApiSide.BookStorageSystem;
using Task3v2ApiSide.ApiSide.PermitionsStorageSystem;
using Task3v2ApiSide.ApiSide.UserAuthorizationSystem;
using Task3v2ApiSide.ClientSide;
using Task3v2ApiSide.ClientSide.ApiServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();

builder.Services.AddTransient<IUserAuthorizationService, UserAuthorizationService>();
builder.Services.AddTransient<IPermitionStorage, PermitionStorage>();
builder.Services.AddTransient<IBookStorage, BookStorage>();

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

var appRun = app.RunAsync();

await Task.Delay(1000);

// Papapa have acces to books named "Jaba" and "Test1", Tes to "AbsoluteBook" and "Jaba" 

var userAuthorization = new UserApiService();
var permits = new PermitionApiService();
var bookStorage = new BookApiService();

var proxy = new BookAccessProxy(bookStorage, permits, userAuthorization);
var bookClient = new BookAccessClient(proxy, userAuthorization);

var book = await bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}

await bookClient.Authorize("Papapa", "qwerty");
book = await bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}

bookClient.ExitAccount();
await bookClient.Authorize("Tes", "12345");
book = await bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}