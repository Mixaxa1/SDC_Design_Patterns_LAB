namespace Task3v2ApiSide.ApiSide.UserAuthorizationSystem
{
    public class UserAuthorizationService : IUserAuthorizationService
    {
        private Dictionary<string, User> _users = new Dictionary<string, User>();

        public UserAuthorizationService()
        {
            Initialize();
        }

        public void Initialize()
        {
            _users.Clear();

            var users = new List<User>()
            {
                new User() {NickName = "Paranoid", Login = "Papapa", Password = "qwerty"},
                new User() {NickName = "Mester", Login = "Tes", Password = "12345"}
            };

            foreach ( var user in users )
            {
                _users.Add( user.Login, user );
            }
        }

        public string? Authorize(string login, string password)
        {
            if (_users.ContainsKey(login))
            {
                if (_users[login].Password == password)
                {
                    return _users[login].NickName;
                }
            }

            return null;
        }

        public bool CheckRegistration (string nickName)
        {
            if (_users.Values.FirstOrDefault(x => x.NickName == nickName) != null)
            {
                return true;
            }
            return false;
        }
    }
}
