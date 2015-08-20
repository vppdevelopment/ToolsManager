using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ToolsManager.Configuration
{
    public class DynamicFormModel
    {
        #region Properties
                
        public ToolModel[] ToolModels { get; set; }

        #endregion
    }
}
