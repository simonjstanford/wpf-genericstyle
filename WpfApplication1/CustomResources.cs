using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library
{
    public class CustomResources
    {
        public static ComponentResourceKey CustomColour
        {
            get
            {
                return new ComponentResourceKey(typeof(CustomResources), "CustomColour");
            }
        }
    }
}
