using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace Shopping_list
{
    public class Xml
    {

        public Xml()
        {
            
        }
        public Xml(Home home)
        {
            this.home = home;
            xdoc = XDocument.Load(xPath);
            root = xdoc.Element("shopinglist");
        }
        
        string xml;
        bool bought;
        string xPath = "E:/SmartHome/ShopingList/00_list_test.xml";

        XDocument xdoc;
        XElement root;

        List list = new List();
        Home home;

        public void loadXml()
        {
            
            foreach (XElement name in xdoc.Element("shopinglist").Elements("product"))
            {
                //XAttribute nameAttribute = phoneElement.Attribute(""); отложим
                XElement nameElement = name.Element("name");
                XElement boughtElement = name.Element("bought");
                XElement deleted = name.Element("deleted");

                if (nameElement != null && boughtElement != null && deleted.Value != "true")
                {
                    if (boughtElement.Value == "true")
                            bought = true;
                    else
                            bought = false;
                    home.addProduct(nameElement.Value, bought);
                }    
                
            }
            
        }
        public void addProduct(string addProduct, int count)
        {
            string id = ""+count;
            root.Add(new XElement("product",
                        new XAttribute("id", id),
                        new XElement("deleted", "false"),
                        new XElement("name", addProduct),
                        new XElement("bought", "false"),
                        new XElement("category", "Разное")));
            xdoc.Save(xPath);
            

        }
        public int getCount() => (from xe in xdoc.Root.Descendants("product") select xe).Count();
        
    }
}
