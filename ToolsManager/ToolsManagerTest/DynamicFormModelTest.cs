using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsManager.Configuration;

namespace ToolsManagerTest
{
    [TestClass]
    public class DynamicFormModelTest
    {
        [TestMethod]
        public void SaveDummyModel()
        {
            //given +
            DynamicFormModel dynamicModel = new DynamicFormModel();
            ToolModel toolModelNotePad = new ToolModel(textButton:"run", actionButton: "notepad.exe");
            ToolModel toolModelBrowser = new ToolModel(textButton: "navigate", actionButton: "www.google.com");
            dynamicModel.ToolModels = new[] {toolModelNotePad, toolModelBrowser };
            
            //when
            DynamicFormModelSerializer.WriteToXmlFile(dynamicModel, path: "Z:\\config.xml");

        }
    }
}
