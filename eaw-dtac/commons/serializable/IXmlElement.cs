using System.Xml.Linq;

namespace eaw.dtac.commons.serializable
{
    internal interface IXmlElement
    {
        XElement ToXmlElement();
    }
}
