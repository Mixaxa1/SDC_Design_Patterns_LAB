using Task3;
using Task3.BookStorageSystem;
using Task3.Storage;
using Task3.UserPermitionStorage;

var bookStorage = new BookStorage();
bookStorage.Initialize();

var userAuthorization = new UserAuthorizationService();
userAuthorization.Initialize();

var userPermits = new UserPermitionService();
userPermits.Initialize();

var authProxy = new AuthProxy(bookStorage, userAuthorization, userPermits);
var bookClient = new BookAccessClient(authProxy, userAuthorization);

var book = bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}

bookClient.Authorize("Papapa", "qwerty");
book = bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}

bookClient.ExitAccount();
bookClient.Authorize("Tes", "12345");
book = bookClient.RequestBookByName("Test1");

if (book != null)
{
    Console.WriteLine(book.ToString());
}
else
{
    Console.WriteLine("book not found or you dont have acces");
}
