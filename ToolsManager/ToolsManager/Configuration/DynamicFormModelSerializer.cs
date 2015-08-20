using System.IO;
using System.Xml.Serialization;

namespace ToolsManager.Configuration
{
    public static class DynamicFormModelSerializer
    {

        #region Public methods

        public static DynamicFormModel ReadFromXmlFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DynamicFormModel));
            using (StreamReader reader = File.OpenText(path))
            {
                DynamicFormModel dynamicFormModel = (DynamicFormModel)serializer.Deserialize(reader);
                return dynamicFormModel;
            }
        }

        public static void WriteToXmlFile(DynamicFormModel dynamicFormModel, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DynamicFormModel));
            using (TextWriter writer = File.CreateText(path))            
                serializer.Serialize(writer, dynamicFormModel);  
        }

        #endregion

    }
}
