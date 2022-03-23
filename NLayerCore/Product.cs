using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore
{
    //classların varsayılanı internaldır.
    //Neden? Proje içinde açık proje dışında açık olmasından dolayı..

    public class Product:BaseEntity
    {
        //public Product(string name)
        //{
        //    Name=name?? throw new ArgumentNullException("name");
        //    //Altının çizilmesini önler. Constraktor kısmında atama yapmak..
        //}
        public string Name { get; set; }
        public int Stock { get; set; }//varsayılan değeri olan yerlerin altı çizilmez..
    //int decimal gibi değerlerin varsayılanı 0 dır.
     //tipinden sonra ? koyar isek string veya class tipli verilere default değer atamış oluruz.

        public decimal Price { get; set; }
        //Otomatik algılar ve foreign key olduğunu anlar.
        public int CategoryID { get; set; }
        //eğer foreign key i farklı isimde oluşturmak gerekirse
        //[ForeignKey("Category_id")] gibi.. YAZMAK GEREKİR.
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}
