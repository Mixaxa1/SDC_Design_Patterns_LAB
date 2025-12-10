namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public interface IUserApiService
    {
        public Task<string?> AuthorizeAsync(string loign, string password);

        public Task<bool> CheckRegistrationAsync(string nickname);
    }
}
