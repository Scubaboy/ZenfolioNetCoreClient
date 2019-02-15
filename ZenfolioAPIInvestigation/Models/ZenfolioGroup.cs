namespace ZenfolioAPIInvestigation.Models
{
    using System;

    public class ZenfolioGroup : ZenFolioGroupElement
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        String PageUrl { get; set; }
    }
}
