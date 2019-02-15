namespace ZenfolioAPIInvestigation.Models
{
    using ZenfolioAPIInvestigation.Types;

    public class ZenfolioAccessDescriptor
    {
        public long RealmId { get; set; }

        public ZenfolioAccessType AccessType { get; set; }

        public ZenfolioAccessMask AccessMask { get; set; }

        public string[] Viewers { get; set; }

        public bool IsDerived { get; set; }

        public string PasswordHint { get; set; }

        public string SrcPasswordHint { get; set; }
    }
}
