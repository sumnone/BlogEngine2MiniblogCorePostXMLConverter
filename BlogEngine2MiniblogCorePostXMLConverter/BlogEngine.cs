using System.Collections.Generic;
using System.Xml.Serialization;

namespace BlogEngine2MiniblogCorePostXMLConverter
{
    public class BlogEngine
    {
		[XmlRoot(ElementName = "tags")]
		public class Tags
		{
			[XmlElement(ElementName = "tag")]
			public List<string> Tag { get; set; }
		}

		[XmlRoot(ElementName = "comment")]
		public class Comment
		{
			[XmlElement(ElementName = "date")]
			public string Date { get; set; }
			[XmlElement(ElementName = "author")]
			public string Author { get; set; }
			[XmlElement(ElementName = "email")]
			public string Email { get; set; }
			[XmlElement(ElementName = "country")]
			public string Country { get; set; }
			[XmlElement(ElementName = "ip")]
			public string Ip { get; set; }
			[XmlElement(ElementName = "content")]
			public string Content { get; set; }
			[XmlAttribute(AttributeName = "id")]
			public string Id { get; set; }
			[XmlAttribute(AttributeName = "parentid")]
			public string Parentid { get; set; }
			[XmlAttribute(AttributeName = "approved")]
			public string Approved { get; set; }
			[XmlAttribute(AttributeName = "spam")]
			public string Spam { get; set; }
			[XmlAttribute(AttributeName = "deleted")]
			public string Deleted { get; set; }
		}

		[XmlRoot(ElementName = "comments")]
		public class Comments
		{
			[XmlElement(ElementName = "comment")]
			public List<Comment> Comment { get; set; }
		}

		[XmlRoot(ElementName = "categories")]
		public class Categories
		{
			[XmlElement(ElementName = "category")]
			public List<string> Category { get; set; }
		}

		[XmlRoot(ElementName = "notifications")]
		public class Notifications
		{
			[XmlElement(ElementName = "email")]
			public List<string> Email { get; set; }
		}

		[XmlRoot(ElementName = "post")]
		public class Post
		{
			[XmlElement(ElementName = "author")]
			public string Author { get; set; }
			[XmlElement(ElementName = "title")]
			public string Title { get; set; }
			[XmlElement(ElementName = "description")]
			public string Description { get; set; }
			[XmlElement(ElementName = "content")]
			public string Content { get; set; }
			[XmlElement(ElementName = "ispublished")]
			public string Ispublished { get; set; }
			[XmlElement(ElementName = "isdeleted")]
			public string Isdeleted { get; set; }
			[XmlElement(ElementName = "iscommentsenabled")]
			public string Iscommentsenabled { get; set; }
			[XmlElement(ElementName = "pubDate")]
			public string PubDate { get; set; }
			[XmlElement(ElementName = "lastModified")]
			public string LastModified { get; set; }
			[XmlElement(ElementName = "raters")]
			public string Raters { get; set; }
			[XmlElement(ElementName = "rating")]
			public string Rating { get; set; }
			[XmlElement(ElementName = "slug")]
			public string Slug { get; set; }
			[XmlElement(ElementName = "tags")]
			public Tags Tags { get; set; }
			[XmlElement(ElementName = "comments")]
			public Comments Comments { get; set; }
			[XmlElement(ElementName = "categories")]
			public Categories Categories { get; set; }
			[XmlElement(ElementName = "notifications")]
			public Notifications Notifications { get; set; }
		}
	}
}
