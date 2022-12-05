using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    public static class ConcatEx
    {
        public static string concatstr(this string fn)
        {
         string re = fn.ToUpper();
            return re ;
        }
    }
}
