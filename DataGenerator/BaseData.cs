using DataGenerator.Data;
using DataGenerator.Helpers;
using DataGenerator.Generation.Settings;
using System;
using System.Collections.Generic;

namespace DataGenerator
{
    public class BaseData
    {
        private int dataCount;
        private readonly Random rng = new();
        public List<Fields> generatedData = new List<Fields>();
        private DataSettingsCollection settings;

        public int DataCount { get; set; }

        public BaseData(int dataCount, DataSettingsCollection dataSettings)
        {
            this.dataCount = dataCount;
            this.settings = dataSettings;
        }

        public void GenerateData()
        {
            DataGenerationHelper.ValidateSettings(settings);
            if (dataCount <= 0 || !DataGenerationHelper.IsGenerateData(settings))
                return;

            for (int i = 0; i < dataCount; i++)
            {
                Fields data = new();
                data.Id = (int?)TryCreateData(nameof(Fields.Id), i);
                data.Guid = (Guid?)TryCreateData(nameof(Fields.Guid));
                data.Integers = (int?)TryCreateData(nameof(Fields.Integers));
                data.Floats = (float?)TryCreateData(nameof(Fields.Floats));
                data.Strings = (string?)TryCreateData(nameof(Fields.Strings), i);
                data.Booleans = (bool?)TryCreateData(nameof(Fields.Booleans));
                data.Base64Strings = (string?)TryCreateData(nameof(Fields.Base64Strings));
                
                generatedData.Add(data);
            }
        }

        private object TryCreateData(string fieldName, int index = 0)
        {
            if (fieldName == nameof(Fields.Id))
                return index;

            var settings = this.settings[fieldName];
            if (settings == null)
                return null;

            if (settings.GenerateField)
            {
                if (settings.AllowNulls && (rng.Next(101) >= settings.PercentOfNulls))
                {
                    switch (fieldName)
                    {
                        case nameof(Fields.Guid):
                            return Guid.NewGuid();

                        case nameof(Fields.Integers):
                            return rng.Next(1000000);

                        case nameof(Fields.Floats):
                            return (float)rng.Next(100) + rng.Next(1000000) / 1000000f;

                        case nameof(Fields.Strings):
                            return "String " + index.ToString("###,00#");

                        case nameof(Fields.Booleans):
                            return Convert.ToBoolean(rng.Next(2));

                        case nameof(Fields.Base64Strings): // need to implement
                            return "test";
                    }
                }
            }
            return null;
        }        
    }
}
