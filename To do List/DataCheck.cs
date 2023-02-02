using System;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Linq;

namespace To_do_List
{
    internal class DataCheck
    {
        private XDocument? xmlDoc;
        private string a =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),("Dados/dados.xml")); 
        static void start()
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dados"));

            // or we can use var a =Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),("Dados/dados.xml")); 
            var pathWithEnv = @"%USERPROFILE%/Documents/Dados/dados.xml";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
        }

        public void addToXml(string checkbox, string conteudo)
        {
            
            {
                xmlDoc = XDocument.Load(a);
                XElement document = new XElement("Chore",
                    new XElement("id", checkbox),
                    new XElement("Check", conteudo));
                xmlDoc.Root.Add(document);
                xmlDoc.Save(a);
            }
        }

    }
    
}
