using System;
using System.Diagnostics;
using System.Windows.Forms;
using ToolsManager.Configuration;

namespace ToolsManager
{
    class DynamicForm : Form
    {
        #region Constructor

        public DynamicForm()
        {
            Text = "Tools manager";
            LoadFromConfiguration("./Tools/configuration.xml");           
        }

        #endregion

        #region Private methods

        private void LoadFromConfiguration(string relativePath)
        {
            DynamicFormModel dynamicFormModel = DynamicFormModelSerializer.ReadFromXmlFile(relativePath);
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.BottomUp;
            Controls.Add(panel);
            foreach (ToolModel toolModel in dynamicFormModel.ToolModels)           
                AddButtonToPanel(panel, toolModel);            
        }

        private void AddButtonToPanel(FlowLayoutPanel panel, ToolModel toolModel)
        {
            ToolButton buttonTool = new ToolButton();
            buttonTool.Text = toolModel.TextButton;
            buttonTool.Action = toolModel.ActionButton;
            buttonTool.Click += ButtonTool_Click;
            panel.Controls.Add(buttonTool);
        }

        private void ButtonTool_Click(object sender, EventArgs e)
        {
            ToolButton button = (ToolButton)sender;
            Process.Start(button.Action);
        }

        #endregion
    }
}
