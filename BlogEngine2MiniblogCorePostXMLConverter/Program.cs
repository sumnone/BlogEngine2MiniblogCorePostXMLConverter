using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace BlogEngine2MiniblogCorePostXMLConverter
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var path = desktop + @"\posts\";
            var outPath = path + @"output\";
            Directory.CreateDirectory(outPath);

            foreach (var file in Directory.EnumerateFiles(path, "*.xml", SearchOption.TopDirectoryOnly))
            {
                
                XmlSerializer mySerializer = new XmlSerializer(typeof(BlogEngine.Post));
                StreamReader streamReader = new StreamReader(file);

                BlogEngine.Post post = (BlogEngine.Post)mySerializer.Deserialize(streamReader);

                var doc = new XDocument(
                            new XElement("post",
                                new XElement("title", post.Title),
                                new XElement("slug", post.Slug.ToLower()),
                                new XElement("pubDate", post.PubDate),
                                new XElement("lastModified", post.LastModified),
                                new XElement("excerpt", post.Title),
                                new XElement("content", post.Content),
                                new XElement("ispublished", post.Ispublished),
                                new XElement("categories", string.Empty),
                                new XElement("comments", string.Empty)
                            ));

                
                //TODO - PIA => Category is a guid and I didn't have any anyway
                //var categories = doc.XPathSelectElement("post/categories");
                //foreach (var category in post.Categories)
                //{
                //    categories.Add(new XElement("category", category));
                //}

                //TODO - Most my previous comments were spam
                //var comments = doc.XPathSelectElement("post/comments");
                //foreach (var comment in post.Comments)
                //{
                //    comments.Add(
                //        new XElement("comment",
                //            new XElement("author", comment.Author),
                //            new XElement("email", comment.Email),
                //            new XElement("date", FormatDateTime(comment.PubDate)),
                //            new XElement("content", comment.Content),
                //            new XAttribute("isAdmin", comment.IsAdmin),
                //            new XAttribute("id", comment.ID)
                //        ));
                //}

                var filePrefix = DateTime.UtcNow.Ticks.ToString(CultureInfo.InvariantCulture);
                var filePath = outPath + filePrefix + ".xml";
                using var fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                await doc.SaveAsync(fs, SaveOptions.None, CancellationToken.None).ConfigureAwait(false);

            }
        }
    }
}
