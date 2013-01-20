using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dalewilbanks.net.rss
{
    public static class WordPressReader
    {
        public static string Read(string feedUrl, string title)
        {
            //XDocument rssFeed = XDocument.Load(@"C:\websites\www.standrewsumc.com\RSS2.xml");
            XDocument rssFeed = XDocument.Load(feedUrl);

            //query the items (rss articlaes) that have a title = Happenings
            var items = rssFeed.Descendants("item").Where(s => s.Descendants("title").First().Value.Equals(title));

            //First resturns the latest item, since items are in reverse chronological order in the rss feed
            var item = items.First();


            //this is how you query for namespaces.  content:encoded is the HTML content of the RSS feed
            XNamespace ns = "http://purl.org/rss/1.0/modules/content/";
            var contentNode = item.Descendants(ns + "encoded").First();

            //remove unwanted links that wordpress includes.  Can't use nodes because it's all CDATA, and can't load it into an XDocument because there are bad chars, so working with it as text.
            var content = contentNode.Value.Substring(0, contentNode.Value.IndexOf("<a rel"));

            //if you write content, it writes the enclosing tags also, so write out content.Value
            return content;
        }
        
    }
}
