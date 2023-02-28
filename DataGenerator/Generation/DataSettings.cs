
namespace DataGenerator.Generation.Settings
{
    public abstract class DataSettings
    {
        protected string name = "";
        private bool generateField;
        private bool allowNulls;
        private byte percentOfNulls;

        public string Name
        {
            get { return name; }
        }
        public bool GenerateField
        {
            get { return generateField; }
            set { generateField = value; }
        }
        public bool AllowNulls
        {
            get { return allowNulls; }
            set { allowNulls = value; }
        }
        public byte PercentOfNulls
        {
            get { return percentOfNulls; }
            set { percentOfNulls = value; }
        }
    }
}
