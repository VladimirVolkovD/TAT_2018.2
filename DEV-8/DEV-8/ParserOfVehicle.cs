using System.Collections.Generic;
using System.Xml;

namespace DEV8
{
    /// <summary>
    ///  Creates List of Vehicle based on XML file.
    /// </summary>
    internal class ParserOfVehicle
    {
        private List<Vehicle> _vehicles;
        private static readonly ParserOfVehicle Instance = new ParserOfVehicle();       

        /// <summary>
        /// Initialize Singleton
        /// </summary>
        private ParserOfVehicle() { }

        /// <summary>
        /// Access to access.
        /// </summary>
        /// <returns>Instance.</returns>
        public static ParserOfVehicle GetInstance()
        {
            return Instance;
        }

        /// <summary>
        /// Parse XML file and search the vehicles instance.
        /// </summary>
        /// <param name="xmlFile">XML file.</param>
        /// <returns>List of Vehicle.></returns>
        public List<Vehicle> GetVehicleList(string xmlFile)
        {
            _vehicles = new List<Vehicle>();
            var xDoc = new XmlDocument();
            xDoc.Load(xmlFile);
            var xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlNode xnode in xRoot)
                {
                    var brand = string.Empty;
                    var model = string.Empty;
                    var quantity = 0;
                    double unitCost = 0;

                    if (xnode.Attributes != null && xnode.Attributes.Count > 0)
                    {
                        var attr = xnode.Attributes.GetNamedItem("Brand");
                        brand = attr.Value;
                    }

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        switch (childnode.Name)
                        {
                            case "model":
                                model = childnode.InnerText;
                                break;
                            case "quantity":
                                quantity = int.Parse(childnode.InnerText);
                                break;
                            case "price":
                                unitCost = double.Parse(childnode.InnerText);
                                break;
                        }
                    }
                    var currentCar = new Vehicle(brand, model, quantity, unitCost);
                    _vehicles.Add(currentCar);
                }
            }
            return _vehicles;
        }   
    }
}

