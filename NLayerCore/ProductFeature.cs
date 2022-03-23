using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore
{
    public class ProductFeature:Product
    {

        public int id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }//Referans Tipli isimlerin altını çizer.
        //.Net6 Nullable: Uygulamada Null hataları almamızı engeller.
        //Altının çizilme sebebi budur.
        //Nullable ı kaldıracak isek kaldırcak olduğumuz katmana veya projeye sağ tıklarız Properties kısmında bulunan
        //Nullable kısmını devredışı bırakırız.
    }
}
