using System.Collections;

namespace DataGenerator.Generation.Settings
{
    public class DataSettingsCollection : CollectionBase
    {
        private void Add(DataSettings dataSettings)
        {
            List.Add(dataSettings);
        }

        private void AddRange(DataSettings[] dataSettings)
        {
            foreach (var settins in dataSettings) 
                Add(settins);
        }

        //public void Remove(DataSettings dataSettings)
        //{
        //    List.Remove(dataSettings);
        //}

        public DataSettings this[int index]
        {
            get
            {
                return (DataSettings)List[index];
            }
        }

        public DataSettings this[string name]
        {
            get
            {
                foreach (DataSettings settings in List)
                {
                    if (settings.Name == name)
                        return settings;
                }

                return null;
            }
        }

        public DataSettingsCollection()
        {
            AddRange(new DataSettings[] { new IdSettings(), new GuidSettings(), new IntegersSettings(), new FloatsSettings(), new StringsSettings(), new BooleansSettings(), new Base64Settings() });
        }
    }
}
