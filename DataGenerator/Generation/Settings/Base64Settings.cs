using DataGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Generation.Settings
{
    public class Base64Settings : DataSettings
    {
        public Base64Settings()
        {
            name = nameof(Fields.Base64Strings);

        }
    }
}
