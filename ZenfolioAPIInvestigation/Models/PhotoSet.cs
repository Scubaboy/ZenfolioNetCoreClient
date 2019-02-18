using System;
using ZenfolioAPIInvestigation.Types;

namespace ZenfolioAPIInvestigation.Models
{
    public class PhotoSet
    {
        public long Id { get; set; }

        public int GroupIndex { get; set; }

        public string Title { get; set; }

        public ZenfolioAccessDescriptor AccessDescriptor { get; set; }

        public string Owner { get; set; }

        public bool HideBranding { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int PhotoCount { get; set; }

        public int ImageCount { get; set; }

        public int VideoCount { get; set; }

        public PhotoType Type { get; set; }

        public string UploadUrl { get; set; }

        public string VideoUploadUrl { get; set; }

        public string RawUploadUrl { get; set; }

        public string PageUrl { get; set; }

        public string MailboxId {get;set;}

        public int TextCn { get; set; }

        public int PhotoListCn { get; set; }
    }
}
