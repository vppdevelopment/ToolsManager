using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ToolsManager.Configuration
{
    public class ToolModel
    {
        #region Properties

        [XmlAttribute]
        public string TextButton { get;  set; }
        public string ActionButton { get;  set; }

        #endregion

        #region Constructors

        public ToolModel(string textButton, string actionButton)
        {
            TextButton = textButton;
            ActionButton = actionButton;
        }

        public ToolModel()
        {

        }

        #endregion
    }
}
