using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task2;
using Task2.Api;
using Task2.Clients;
using Task2.Db;
using Task2.Db.Entities;
using Task2.Proxy;

using (var context = new AppDbContext())
{
    context.Database.EnsureCreated();

    var someApi = new ApiController();
    var someProxy = new ApiValidationProxy(someApi);
    var crudClient = new SomeCrudApiClient(someProxy);

    crudClient.Create("test66", "66 ATEMPT", "active");
    var somes = crudClient.GetAll();

    foreach (var some in somes)
    {
        Console.WriteLine(some.ToString());
    }

    Console.WriteLine();

    var imgApi = new ImageApiController();
    var imgProxy = new ImageApiValidationProxy(imgApi);
    var flexibleClient = new FlexibleClient(someProxy, imgProxy);

    var imgs = flexibleClient.ImgFlexibleSearch(description: "test");

    foreach (var img in imgs)
    {
        Console.WriteLine(img.ToString());
    }
}