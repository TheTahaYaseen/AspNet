using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class CommandEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button.Text = "Call Command And Click";
            Button.Click += new EventHandler(ButtonClickEvent);
            Button.Command += new CommandEventHandler(ButtonCommandEvent);

            PrintButton.Click += new EventHandler(ButtonClickEvent);
            PrintButton.CommandName = "Print";
            PrintButton.Text = "Print";
            PrintButton.Command += new CommandEventHandler(ButtonCommandEvent);

            ShowButton.Click += new EventHandler(ButtonClickEvent);
            ShowButton.CommandName = "Show";
            ShowButton.Text = "Show";
            ShowButton.Command += new CommandEventHandler(ButtonCommandEvent);

            TruthButton.Click += new EventHandler(ButtonClickEvent);
            TruthButton.CommandName = "Tell";
            TruthButton.CommandArgument = "Truth";
            TruthButton.Text = "Truth";
            TruthButton.Command += new CommandEventHandler(ButtonCommandEvent);

            LieButton.Click += new EventHandler(ButtonClickEvent);
            LieButton.CommandName = "Tell";
            LieButton.CommandArgument = "Lie";
            LieButton.Text = "Lie";
            LieButton.Command += new CommandEventHandler(ButtonCommandEvent);
        }

        protected void ButtonClickEvent(object sender, EventArgs e) 
        {
            Response.Write("Button click fired. <br>");
        }

        protected void ButtonCommandEvent(object sender, CommandEventArgs e)
        {
            Response.Write("Button command fired. <br>");
            switch (e.CommandName)
            {
                case "Print":
                    Response.Write("Printed");
                    break;
                case "Show":
                    Response.Write("Shown");
                    break;
                case "Tell":
                    if(e.CommandArgument == "Truth")
                    {
                        Response.Write("Truth told");
                    }
                    else
                    {
                        Response.Write("Lie told");
                    }
                    break;
            }
        }

    }
}