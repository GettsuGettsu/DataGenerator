using DataGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator.Generation.Settings
{
    public class GuidSettings : DataSettings
    {
        public GuidSettings()
        {
            name = nameof(Fields.Guid);
        }
    }
}
