using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3
{
    public static class ConfigConection
    {
        public static string Connection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
    }
}
