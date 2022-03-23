using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerCore
{
    public abstract class BaseEntity//Soyut nesneler newlenemez..
    {
        //[Key] eğer id yazmasaydık başına Key yazmak gerekirdi..

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }//Başlangıç değeri null olmalıdır.
        //ortak kullanılan kısımları oluşturduk.
    }
}
