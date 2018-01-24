namespace WebApplication1.Model
{
    public class CountExists
    {
        public int Count { get; }
        public bool Exists { get; set; }

        public CountExists (int count, bool exists)
        {
            Count = count;
            Exists = exists;
        }
    }
}





