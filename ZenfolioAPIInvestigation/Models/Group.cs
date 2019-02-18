namespace ZenfolioAPIInvestigation.Models
{
    using System;
    using System.Xml.Serialization;

   
    public class Group 
    {
        public long Id { get; set; }

        public int GroupIndex { get; set; }

        public string Title { get; set; }

        public ZenfolioAccessDescriptor AccessDescriptor { get; set; }

        public string Owner { get; set; }
    
    public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string PageUrl { get; set; }

        public ZenfolioPhoto TitlePhoto { get; set; }

        public string MailboxId { get; set;}

        public int ImmediateChildrenCount { get; set; }

        public int TextCn { get; set; }

        public string Caption { get; set; }

        public int CollectionCount { get; set; }
        public int SubGroupCount { get; set; }
        public int GalleryCount { get; set; }
        public int PhotoCount { get; set; }
        public long[] ParentGroups { get; set; }

        public ZenFolioGroupElement[] Elements { get; set; }

    }
}
