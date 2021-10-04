using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InvoiceDesingTest
{
    public class Bank
    {
        public string bankname { get; set; }

        public string bankcode { get; set; }

        public string bankiban { get; set; }
    }



    public partial class invoicedesing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());

                string directory = System.AppDomain.CurrentDomain.BaseDirectory + "images\\bankinfo.txt";
                var array = File.ReadAllLines(directory);

                foreach (string infos in array)
                {
                    HtmlTableRow row = new HtmlTableRow();
                    HtmlTableCell cell = new HtmlTableCell();
                    HtmlTableCell cell2 = new HtmlTableCell();
                    HtmlTableCell cell3 = new HtmlTableCell();

                    string[] veriler = infos.Split(",".ToCharArray());
                    cell.InnerText = veriler[0];
                    cell2.InnerText = veriler[1];
                    cell3.InnerText = veriler[2];

                    row.Cells.Add(cell);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);

                    BankInfoTable.Rows.Add(row);
                }

                txtbxbankinfo1.Text = "";
                txtbxbankinfo2.Text = "";
                txtbxbankinfo3.Text = "";
            }

           
        }

        //protected override void Render(HtmlTextWriter writer)
        //{
        //    StringBuilder sbOut = new StringBuilder();
        //    StringWriter swOut = new StringWriter(sbOut);
        //    HtmlTextWriter htwOut = new HtmlTextWriter(swOut);
        //    base.Render(htwOut);
        //    string sOut = sbOut.ToString();

        //    StreamWriter yaz = new StreamWriter(@"C:\Users\bilge\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\htmloutput.txt", true);

        //    yaz.WriteLine(sOut);
        //    yaz.Close();

        //    writer.Write(sOut);
        //}


        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string directory = System.AppDomain.CurrentDomain.BaseDirectory + "images\\bankinfo.txt";
            var array = File.ReadAllLines(directory);

            foreach (string infos in array)
            {
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell = new HtmlTableCell();
                HtmlTableCell cell2 = new HtmlTableCell();
                HtmlTableCell cell3 = new HtmlTableCell();

                string[] veriler = infos.Split(",".ToCharArray());
                cell.InnerText = veriler[0];
                cell2.InnerText = veriler[1];
                cell3.InnerText = veriler[2];

                row.Cells.Add(cell);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);

                BankInfoTable.Rows.Add(row);
            }

            try
            {
                string FileName = Path.GetFileName(FileUploadLogo.PostedFile.FileName);
                //Save files to images folder
                FileUploadLogo.SaveAs(Server.MapPath("images/" + FileName));
                this.ImageCompanyLogo.Src = "images/" + FileName;
                ImageCompanyLogo.Attributes.Add("border", "0");
            }
            catch (Exception ex)
            {
                lbluploadimageerror.Visible = true;
                lbluploadimageerror.Text = "LÜTFEN GEÇERLİ BİR IMAGE EKLEYİN";
            }


            if (FileUploadLogo.HasFile==true)
            {
                lbluploadimageerror.Visible = false;
            }


           
        }


        protected void BtnApplyColor_Click(object sender, EventArgs e)
        {
            string directory = System.AppDomain.CurrentDomain.BaseDirectory + "images\\bankinfo.txt";
            var array = File.ReadAllLines(directory);

            foreach (string infos in array)
            {
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell = new HtmlTableCell();
                HtmlTableCell cell2 = new HtmlTableCell();
                HtmlTableCell cell3 = new HtmlTableCell();

                string[] veriler = infos.Split(",".ToCharArray());
                cell.InnerText = veriler[0];
                cell2.InnerText = veriler[1];
                cell3.InnerText = veriler[2];

                row.Cells.Add(cell);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);

                BankInfoTable.Rows.Add(row);
            }

         

        protected void btnenterbankinfo_Click(object sender, EventArgs e)
        {
            if (Session["update"].ToString()==ViewState["update"].ToString())
            {
                StreamWriter yaz = new StreamWriter(@"C:\Users\bilge\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt", true);

                yaz.WriteLine(txtbxbankinfo1.Text + "," + txtbxbankinfo2.Text + "," + txtbxbankinfo3.Text);
                yaz.Close();

                string directory = System.AppDomain.CurrentDomain.BaseDirectory + "images\\bankinfo.txt";
                var array = File.ReadAllLines(directory);

                foreach (string infos in array)
                {
                    HtmlTableRow row = new HtmlTableRow();
                    HtmlTableCell cell = new HtmlTableCell();
                    HtmlTableCell cell2 = new HtmlTableCell();
                    HtmlTableCell cell3 = new HtmlTableCell();

                    string[] veriler = infos.Split(",".ToCharArray());
                    cell.InnerText = veriler[0];
                    cell2.InnerText = veriler[1];
                    cell3.InnerText = veriler[2];

                    row.Cells.Add(cell);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);

                    BankInfoTable.Rows.Add(row);
                }

                txtbxbankinfo1.Text = "";
                txtbxbankinfo2.Text = "";
                txtbxbankinfo3.Text = "";

                Session["update"] = Server.UrlEncode(System.DateTime.Now.ToString());

            }
            else
            {
                string directory = System.AppDomain.CurrentDomain.BaseDirectory + "images\\bankinfo.txt";
                var array = File.ReadAllLines(directory);

                foreach (string infos in array)
                {
                    HtmlTableRow row = new HtmlTableRow();
                    HtmlTableCell cell = new HtmlTableCell();
                    HtmlTableCell cell2 = new HtmlTableCell();
                    HtmlTableCell cell3 = new HtmlTableCell();

                    string[] veriler = infos.Split(",".ToCharArray());
                    cell.InnerText = veriler[0];
                    cell2.InnerText = veriler[1];
                    cell3.InnerText = veriler[2];

                    row.Cells.Add(cell);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);

                    BankInfoTable.Rows.Add(row);
                }

                txtbxbankinfo1.Text = "";
                txtbxbankinfo2.Text = "";
                txtbxbankinfo3.Text = "";
            }


        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            ViewState["update"] = Session["update"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
