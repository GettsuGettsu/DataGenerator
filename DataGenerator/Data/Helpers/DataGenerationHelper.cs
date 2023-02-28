using DataGenerator.Generation.Settings;

namespace DataGenerator.Helpers
{
    internal class DataGenerationHelper
    {
        internal static void ValidateSettings(DataSettingsCollection settings)
        {
            foreach (DataSettings item in settings)
            {
                if (item.Name == "Id")
                    return;
                if (item.PercentOfNulls == 100)
                    item.GenerateField = false;
            }
        }

        internal static bool IsGenerateData(DataSettingsCollection dataSettings)
        {
            bool isNeedToGenerate = false;
            foreach (DataSettings item in dataSettings)
            {
                isNeedToGenerate |= item.GenerateField;
            }

            return isNeedToGenerate;
        }
    }
}
