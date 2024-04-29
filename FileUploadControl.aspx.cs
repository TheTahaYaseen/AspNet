using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.Net
{
    public partial class FileUploadControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UploadButton.Text = "Upload";
            Label.Text = "Please select a file to upload.";
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            if (FileInput.HasFile)
            {
                string FileExtension = Path.GetExtension(FileInput.FileName);
                if (FileExtension.ToLower() != ".py" && FileExtension.ToLower() != ".pyw")
                {
                    Label.ForeColor = Color.Red;
                    Label.Text = "Only .py or .pyw files are allowed.";
                }
                else
                {
                    int FileSize = FileInput.PostedFile.ContentLength;
                    if (FileSize > 2097152)
                    {
                        Label.ForeColor = Color.Red;
                        Label.Text = "Only files smaller than 2mb(s) are allowed.";
                    }
                    else
                    {
                        FileInput.SaveAs(Server.MapPath("~/Uploads/" + FileInput.FileName));
                        Label.ForeColor = Color.Green;
                        Label.Text = "File successfully uploaded.";
                    }
                }
            }
            else
            {
                Label.ForeColor = Color.Red;
                Label.Text = "Please select a file to upload.";
            }
        }
    }
}