using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace APITest
{
    public static class Models
    {

        public static ArrayOfProduct getProducts(Uri modelUri)
        {

            XmlSerializer serial = new XmlSerializer(typeof(ArrayOfProduct));
            ArrayOfProduct products;
            XmlReader xProducts = Utilities.get(modelUri);
            using (xProducts)
            {
                products = (ArrayOfProduct)serial.Deserialize(xProducts);
            }

            return products;
        }

        public static Dictionary<string, string> getItemByID(ArrayOfProduct products, string id)
        {
            Dictionary<string, string> itemDic = new Dictionary<string, string>();

            foreach (var product in products.Items)
            {
                if (product.Id == id)
                {
                    itemDic.Add("name", product.Name);
                    itemDic.Add("id", product.Id);
                    itemDic.Add("desc", product.Description);
                }
            }

            return itemDic;

        }

    }
}
