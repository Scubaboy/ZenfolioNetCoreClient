namespace ZenfolioAPIInvestigation.Models
{
    public class ZenFolioGroupElement
    {
        public long Id { get; set; }

        public int GroupIndex { get; set; }

        public string Title { get; set;}

        public ZenfolioAccessDescriptor AccessDescriptor { get; set; }

        public string Owner { get; set; }
    }
}
