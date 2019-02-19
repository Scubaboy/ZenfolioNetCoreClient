namespace ZenfolioAPIInvestigation.ResponseConverters
{
    using System.IO;
    using System.Xml.Serialization;
    using ZenfolioAPIInvestigation.Models;

    public class PhotoSetXmlResponseConverter : IResponseConverter<PhotoSet>
    {
        public PhotoSet XMLTo(string xmlResponse)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "PhotoSet";
            xRoot.Namespace = "http://www.zenfolio.com/api/1.8";
            xRoot.IsNullable = true;
            var serializer = new XmlSerializer(typeof(PhotoSet), xRoot);
            using (var reader = new StringReader(xmlResponse))
            {
                return (PhotoSet)serializer.Deserialize(reader);
            }
        }
    }
}
