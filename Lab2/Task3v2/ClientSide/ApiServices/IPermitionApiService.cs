namespace Task3v2ApiSide.ClientSide.ApiServices
{
    public interface IPermitionApiService
    {
        public Task<bool> CheckPermitionAsync(string nickname, string book);
    }
}
