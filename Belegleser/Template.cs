using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Belegleser
{
    public class Template
    {
        public List<Area> Reactangles
        {
            get; set;
        }

        public List<Index> Index
        {
            get; set;
        }

        public static Template getFromFile(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Template));

            using (StreamReader writer = new StreamReader(fileName))
            {
                return (Template)serializer.Deserialize(writer);
            }

        }
    }
}
