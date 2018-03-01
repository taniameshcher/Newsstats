using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model.Deserialization;

namespace WebApplication1.Model
{
    public class ArticleHandler
    {
        private GoogleNews _googleNews;
        public ArticleHandler(GoogleNews googleNews)
        {
            _googleNews = googleNews;
        }

        public void CountByKeyword(string keyword)
        {
            WordFinder wordFinder = new WordFinder();
            if (_googleNews.articles == null)
            {
                throw new Exception("There are no articles available");
            }
            else
            {
                foreach (Article article in _googleNews.articles)
                {
                    if (SumAccumulation.CacheDictionary.ContainsKey(article.url))
                    {
                        SumAccumulation.CacheDictionary[article.url].Exists = true;
                    }
                    else
                    {
                        int count = wordFinder.Find(keyword, article.description);
                        SumAccumulation.Sum += count;
                        CountExists countExists = new CountExists(count, true, article);
                        SumAccumulation.CacheDictionary.Add(article.url, countExists);
                    }
                }

                foreach (var item in SumAccumulation.CacheDictionary.Where(a => !a.Value.Exists).ToList())
                {
                    SumAccumulation.CacheDictionary.Remove(item.Key);
                }

                foreach (string key in SumAccumulation.CacheDictionary.Keys)
                {
                    SumAccumulation.CacheDictionary[key].Exists = false;
                }

            }

        }
    }
}
