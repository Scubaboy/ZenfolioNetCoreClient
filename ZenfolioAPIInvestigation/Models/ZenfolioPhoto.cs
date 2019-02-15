namespace ZenfolioAPIInvestigation.Models
{
    using System;
    using ZenfolioAPIInvestigation.Types;

    public class ZenfolioPhoto
    {
        public long Id { get; set; }

        public uint Width { get; set; }

        public uint Height { get; set; }

        public string Sequence { get; set; }

        public ZenfolioAccessDescriptor AccessDescriptor { get; set; }

        public string Owner { get; set; }

        public string Title { get; set; }

        public string MimeType { get; set; }

        public int Views { get; set; }

        public int Size { get; set; }

        public int Gallery { get; set; }

        public string OriginalUrl { get; set; }

        public string UrlCore { get; set; }

        public string UrlHost { get; set; }

        public string UrlToken { get; set; }

        public string PageUrl { get; set; }

        public string MailboxId { get; set; }

        public int TextCn { get; set; }

        public ZenfolioPhotoFlags Flags { get; set; }

        public bool IsVideo { get; set; }

        public int Duration { get; set; }

        public string Caption { get; set; }

        public string FileName { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime TakenOn { get; set; }

        public string[] Keywords { get; set; }

        public int[] Categories { get; set; }

        public string Copyright { get; set; }

        public ZenfolioPhotoRotation Rotation { get; set; }

        public ZenfolioExifTag[] ExifTags { get; set; }
        
        public string ShortExif { get; set; }

    }
}
