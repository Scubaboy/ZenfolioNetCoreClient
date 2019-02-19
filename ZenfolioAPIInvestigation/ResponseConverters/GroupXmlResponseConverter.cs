namespace ZenfolioAPIInvestigation.ResponseConverters
{
    using System.IO;
    using System.Xml.Serialization;
    using ZenfolioAPIInvestigation.Models;

    public class GroupXmlResponseConverter : IResponseConverter<Group>
    {
        public Group XMLTo(string xmlResponse)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Group";
            xRoot.Namespace = "http://www.zenfolio.com/api/1.8";
            xRoot.IsNullable = true;
            var serializer = new XmlSerializer(typeof(Group), xRoot);
            using (var reader = new StringReader(xmlResponse))
            {
                return (Group)serializer.Deserialize(reader);
            }
        }
    }
}
