using WebApplication1.Model.Deserialization;

namespace WebApplication1.Model
{
    public class CountExists
    {
        public int Count { get; }
        public bool Exists { get; set; }
        public Article Article { get; }

        public CountExists (int count, bool exists, Article article)
        {
            Count = count;
            Exists = exists;
            Article = article;
        }
    }
}





