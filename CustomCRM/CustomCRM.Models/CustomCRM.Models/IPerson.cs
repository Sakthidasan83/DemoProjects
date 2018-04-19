using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRM.Models
{
    public interface IPerson<TKey>
    {
         TKey ID { get; set; }
         string Name { get; set; }
    }
}
