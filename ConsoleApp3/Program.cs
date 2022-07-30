using System;
using System.Xml.Serialization;

namespace ConsoleApp3
{
	[XmlRoot(ElementName = "CAT")]
	public class CAT
	{

		[XmlElement(ElementName = "NAME")]
		public string NAME { get; set; }

		[XmlElement(ElementName = "BREED")]
		public string BREED { get; set; }

		[XmlElement(ElementName = "AGE")]
		public int AGE { get; set; }

		[XmlElement(ElementName = "ALTERED")]
		public string ALTERED { get; set; }

		[XmlElement(ElementName = "DECLAWED")]
		public string DECLAWED { get; set; }

		[XmlElement(ElementName = "LICENSE")]
		public string LICENSE { get; set; }

		[XmlElement(ElementName = "OWNER")]
		public string OWNER { get; set; }
	}
}
