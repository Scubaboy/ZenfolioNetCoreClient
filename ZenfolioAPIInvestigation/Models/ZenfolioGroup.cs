namespace ZenfolioAPIInvestigation.Models
{
    using System;

    public class ZenfolioGroup : ZenFolioGroupElement
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        String PageUrl { get; set; }
        ZenfolioPhoto TitlePhoto { get; set; }
        public string MailBoxId { get; set;}

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
