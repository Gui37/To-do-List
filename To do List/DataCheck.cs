using System;
using System.Linq;
using System.Xml.Linq;

namespace To_do_List
{
    internal class DataCheck
    {
        public void start()
        {
            Form1 fr = new Form1();
            fr.dialogBox();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dados"));
            XDocument xmlFromPlainCode = XmlUsingPlainCode();

            var pathWithEnv = @"%USERPROFILE%/Documents/Dados/dados.xml";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            xmlFromPlainCode.Save(filePath);

            PerformLinqQueryOnXml(filePath);

            Console.WriteLine(xmlFromPlainCode);
        }
        static void PerformLinqQueryOnXml(string docPath)
        {
            XElement document = XElement.Load(docPath); // Load document as an XML Element

            var amountOfCheck= document.Elements("Check"); // Get the check elements into an enumerator

            Console.WriteLine("------ # Extract Courses In Document Using LINQ# ------\n");

            // Write out each check details to the console
            foreach (var check in amountOfCheck)
            {
                Console.WriteLine("### Course Details ###");
                Console.WriteLine($"Course: {check.Element("Desc").Value}");
            }
        }

        static XDocument XmlUsingPlainCode()
        {
            
            XDocument document = new XDocument
         (
             new XDeclaration("1.0", "utf-8", "yes"),
             new XComment("XML from plain code"),
             new XElement("To Do",
                 new XElement("Check",
                     new XAttribute("Id", 1),
                     new XElement("Desc", "Code")),
                 new XElement("Check",
                     new XAttribute("Id", 2),
                     new XElement("Desc", "Play VideoGames"))
                 )
             );

            return document;
        }
    }

    
}
