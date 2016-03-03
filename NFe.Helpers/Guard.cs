using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFe.Helpers
{
   public class Guard
    {

     public static void ForNullOrEmpty(string value,string msgErro)
     {
       if (String.IsNullOrEmpty(value))
             throw new Exception(msgErro);
      
     }

    }
}
