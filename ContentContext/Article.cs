using System.Collections.Generic;
using OOP_App.NotificationContext;

namespace OOP_App.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url)
            : base(title, url)
        {
        }
    }
}