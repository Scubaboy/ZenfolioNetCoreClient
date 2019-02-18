namespace ZenfolioAPIInvestigation.ResponseConverters
{
    using System.IO;
    using System.Xml.Serialization;

    public class XmlResponseConverter : IResponseConverter
    {
        public T XMLTo<T>(string xmlResponse)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Group";
            xRoot.Namespace = "http://www.zenfolio.com/api/1.8";
            xRoot.IsNullable = true;
            var serializer = new XmlSerializer(typeof(T), xRoot);
            using (var reader = new StringReader(xmlResponse))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
