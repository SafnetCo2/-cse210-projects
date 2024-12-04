using Sytem;
namespace library_demo
{
    public class Book
    {
        private string _author = "";
        private string _title = "";

        public string GetAuthor()
        {
            return _author;
        }
        public void SetAuthor(string _author){
            _author = author;
        }
        public string GetTitle()
        {
            return _title;
        }
        public string SetTitle(string _title)
        {
            _title =title;
        }
        public string GetBookInfo(){
            return $"{title} by {_author} ";
        }
    }
}