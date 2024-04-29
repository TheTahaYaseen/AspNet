using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class PanelControlGeneration : System.Web.UI.Page
    {
        ListItem ControlTypeLabel = new ListItem("Label");
        ListItem ControlTypeTextbox = new ListItem("Textbox");
        ListItem ControlTypeButton = new ListItem("Button");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ControlsLabel.Text = "Control Types";
                ControlsCountLabel.Text = "How Many?";
                LabelControlsLabel.Text = "Labels";
                TextboxControlsLabel.Text = "Textboxes";
                ButtonControlsLabel.Text = "Buttons";

                ControlsSelection.Items.Add(ControlTypeLabel);
                ControlsSelection.Items.Add(ControlTypeTextbox);
                ControlsSelection.Items.Add(ControlTypeButton);

                GenerateButton.Text = "Generate";
            }
        }

        protected void GenerateButton_Click(object sender, EventArgs e)
        {

            int CountToAdd = Convert.ToInt32(ControlsCount.Text);

            foreach(ListItem ControlType in ControlsSelection.Items)
            {
                if (ControlType.Selected)
                {
                    if (ControlType.Value == "Label")
                    {
                        for (int iteration = 0; iteration < CountToAdd; iteration++)
                        {
                            Label Label = new Label();
                            Label.Text = "Label #" + (iteration + 1).ToString();
                            LabelsPanel.Controls.Add(Label);
                            Literal LineBreak = new Literal() { Text = "<br/>" };
                            LabelsPanel.Controls.Add(LineBreak);
                        }
                    }

                    else if (ControlType.Value == "Textbox")
                    {
                        for (int iteration = 0; iteration < CountToAdd; iteration++)
                        {
                            TextBox TextBox = new TextBox();
                            TextBox.Text = "TextBox #" + (iteration + 1).ToString();
                            TextboxesPanel.Controls.Add(TextBox);
                            Literal LineBreak = new Literal() { Text = "<br/>"};
                            TextboxesPanel.Controls.Add(LineBreak);
                        }
                    }

                    else
                    {
                        for (int iteration = 0; iteration <  CountToAdd; iteration++)
                        {
                            Button Button = new Button();
                            Button.Text = "Button #" + (iteration + 1).ToString();
                            ButtonsPanel.Controls.Add(Button);
                            Literal LineBreak = new Literal() { Text = "<br/>" };
                            ButtonsPanel.Controls.Add(LineBreak);
                        }
                    }
                }
            }
        }
    }
}