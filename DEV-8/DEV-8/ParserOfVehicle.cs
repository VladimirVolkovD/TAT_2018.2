using System.Collections.Generic;
using System.Xml;

namespace DEV8
{
    class ParserOfVehicle
    {
        private static readonly ParserOfVehicle instance = new ParserOfVehicle();
        List<Vehicle> Vehicles;
        private ParserOfVehicle() { }

        public static ParserOfVehicle GetInstance()
        {
            return instance;
        }

        public List<Vehicle> GetVehicleList(string xmlFile)
        {
            Vehicles = new List<Vehicle>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xmlFile);
            XmlElement xRoot = xDoc.DocumentElement;
            string typeOfVehicle = xRoot.ToString();
            foreach (XmlNode xnode in xRoot)
            {
                string brand = string.Empty;
                string model = string.Empty;
                int quantity = 0;
                double unitCost = 0;

                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("Brand");
                    brand = attr.Value;
                }
              
                foreach (XmlNode childnode in xnode.ChildNodes)
                {                    
                    if (childnode.Name == "model")
                    {
                        model = childnode.InnerText;  
                    }

                    if (childnode.Name == "quantity")
                    {
                        quantity = int.Parse(childnode.InnerText.ToString());
                    }

                    if (childnode.Name == "price")
                    {
                        unitCost = double.Parse(childnode.InnerText);
                    }
                }
                Vehicle currenttCar = new Vehicle(brand, model, quantity, unitCost);
                Vehicles.Add(currenttCar);                
            }
            return Vehicles;
        }   
    }
}

