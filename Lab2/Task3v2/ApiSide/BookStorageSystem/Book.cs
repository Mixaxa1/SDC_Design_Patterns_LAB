namespace Task3v2ApiSide.ApiSide.BookStorageSystem
{
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Title + " - " + Description;
        }
    }
}
