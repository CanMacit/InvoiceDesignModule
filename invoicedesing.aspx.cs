using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

                var array = File.ReadAllLines(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt");

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
            var array = File.ReadAllLines(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt");

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
            var array = File.ReadAllLines(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt");

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

            if (DropDownListColor.SelectedItem.ToString() == DropDownListHeaderColor.SelectedItem.ToString())
            {
                lblcheckcolor.Visible = true;
                lblcheckcolor.Text = "Header color and desing color is same.";
            }
            else
            {
                lblcheckcolor.Visible = false;
            }


            if (DropDownListColor.SelectedIndex == 0)
            {
                InvoiceDesingDiv.Style.Add("color", "black");
            }

            if (DropDownListColor.SelectedIndex == 1)
            {
                InvoiceDesingDiv.Style.Add("color", "grey");
            }

            else if (DropDownListColor.SelectedIndex == 2)
            {
                InvoiceDesingDiv.Style.Add("color", "brown");
            }

            else if (DropDownListColor.SelectedIndex == 3)
            {
                InvoiceDesingDiv.Style.Add("color", "green");
            }

            else if (DropDownListColor.SelectedIndex == 4)
            {
                InvoiceDesingDiv.Style.Add("color", "blue");
            }

            else if (DropDownListColor.SelectedIndex == 5)
            {
                InvoiceDesingDiv.Style.Add("color", "chocolate");
            }







            if (DropDownListHeaderColor.SelectedIndex == 0)
            {
                banktd1.Style.Add("background-color", "white");
                bankth1.Style.Add("background-color", "white");
                bankth2.Style.Add("background-color", "white");
                bankth3.Style.Add("background-color", "white");
                kalemth3.Style.Add("background-color", "white");
                kalemth4.Style.Add("background-color", "white");
                kalemth5.Style.Add("background-color", "white");
                kalemth6.Style.Add("background-color", "white");
                kalemth7.Style.Add("background-color", "white");
                kalemth8.Style.Add("background-color", "white");
                kalemth2.Style.Add("background-color", "white");
                kalemth1.Style.Add("background-color", "white");
                kalemth10.Style.Add("background-color", "white");
                kalemth11.Style.Add("background-color", "white");
                invoiceinfotd1.Style.Add("background-color", "white");
                invoiceinfotd2.Style.Add("background-color", "white");
                invoiceinfotd3.Style.Add("background-color", "white");
                invoiceinfotd4.Style.Add("background-color", "white");
                invoiceinfotd5.Style.Add("background-color", "white");
                invoiceinfotd6.Style.Add("background-color", "white");
                invoiceinfotd7.Style.Add("background-color", "white");
                kalem2th1.Style.Add("background-color", "white");
                kalem2th2.Style.Add("background-color", "white");
                kalem2th3.Style.Add("background-color", "white");
                kalem2th4.Style.Add("background-color", "white");
                kalem2th5.Style.Add("background-color", "white");
            }

            else if (DropDownListHeaderColor.SelectedIndex == 1)
            {
                banktd1.Style.Add("background-color", "brown");
                bankth1.Style.Add("background-color", "brown");
                bankth2.Style.Add("background-color", "brown");
                bankth3.Style.Add("background-color", "brown");
                kalemth3.Style.Add("background-color", "brown");
                kalemth4.Style.Add("background-color", "brown");
                kalemth5.Style.Add("background-color", "brown");
                kalemth6.Style.Add("background-color", "brown");
                kalemth7.Style.Add("background-color", "brown");
                kalemth8.Style.Add("background-color", "brown");
                kalemth2.Style.Add("background-color", "brown");
                kalemth1.Style.Add("background-color", "brown");
                kalemth10.Style.Add("background-color", "brown");
                kalemth11.Style.Add("background-color", "brown");
                invoiceinfotd1.Style.Add("background-color", "brown");
                invoiceinfotd2.Style.Add("background-color", "brown");
                invoiceinfotd3.Style.Add("background-color", "brown");
                invoiceinfotd4.Style.Add("background-color", "brown");
                invoiceinfotd5.Style.Add("background-color", "brown");
                invoiceinfotd6.Style.Add("background-color", "brown");
                invoiceinfotd7.Style.Add("background-color", "brown");
                kalem2th1.Style.Add("background-color", "brown");
                kalem2th2.Style.Add("background-color", "brown");
                kalem2th3.Style.Add("background-color", "brown");
                kalem2th4.Style.Add("background-color", "brown");
                kalem2th5.Style.Add("background-color", "brown");
            }

            else if (DropDownListHeaderColor.SelectedIndex == 2)
            {
                banktd1.Style.Add("background-color", "green");
                bankth1.Style.Add("background-color", "green");
                bankth2.Style.Add("background-color", "green");
                bankth3.Style.Add("background-color", "green");
                kalemth3.Style.Add("background-color", "green");
                kalemth4.Style.Add("background-color", "green");
                kalemth5.Style.Add("background-color", "green");
                kalemth6.Style.Add("background-color", "green");
                kalemth7.Style.Add("background-color", "green");
                kalemth8.Style.Add("background-color", "green");
                kalemth2.Style.Add("background-color", "green");
                kalemth1.Style.Add("background-color", "green");
                kalemth10.Style.Add("background-color", "green");
                kalemth11.Style.Add("background-color", "green");
                invoiceinfotd1.Style.Add("background-color", "green");
                invoiceinfotd2.Style.Add("background-color", "green");
                invoiceinfotd3.Style.Add("background-color", "green");
                invoiceinfotd4.Style.Add("background-color", "green");
                invoiceinfotd5.Style.Add("background-color", "green");
                invoiceinfotd6.Style.Add("background-color", "green");
                invoiceinfotd7.Style.Add("background-color", "green");
                kalem2th1.Style.Add("background-color", "green");
                kalem2th2.Style.Add("background-color", "green");
                kalem2th3.Style.Add("background-color", "green");
                kalem2th4.Style.Add("background-color", "green");
                kalem2th5.Style.Add("background-color", "green");
            }

            else if (DropDownListHeaderColor.SelectedIndex == 3)
            {
                banktd1.Style.Add("background-color", "blue");
                bankth1.Style.Add("background-color", "blue");
                bankth2.Style.Add("background-color", "blue");
                bankth3.Style.Add("background-color", "blue");
                kalemth3.Style.Add("background-color", "blue");
                kalemth4.Style.Add("background-color", "blue");
                kalemth5.Style.Add("background-color", "blue");
                kalemth6.Style.Add("background-color", "blue");
                kalemth7.Style.Add("background-color", "blue");
                kalemth8.Style.Add("background-color", "blue");
                kalemth2.Style.Add("background-color", "blue");
                kalemth1.Style.Add("background-color", "blue");
                kalemth10.Style.Add("background-color", "blue");
                kalemth11.Style.Add("background-color", "blue");
                invoiceinfotd1.Style.Add("background-color", "blue");
                invoiceinfotd2.Style.Add("background-color", "blue");
                invoiceinfotd3.Style.Add("background-color", "blue");
                invoiceinfotd4.Style.Add("background-color", "blue");
                invoiceinfotd5.Style.Add("background-color", "blue");
                invoiceinfotd6.Style.Add("background-color", "blue");
                invoiceinfotd7.Style.Add("background-color", "blue");
                kalem2th1.Style.Add("background-color", "blue");
                kalem2th2.Style.Add("background-color", "blue");
                kalem2th3.Style.Add("background-color", "blue");
                kalem2th4.Style.Add("background-color", "blue");
                kalem2th5.Style.Add("background-color", "blue");
            }

            else if (DropDownListHeaderColor.SelectedIndex == 4)
            {
                banktd1.Style.Add("background-color", "chocolate");
                bankth1.Style.Add("background-color", "chocolate");
                bankth2.Style.Add("background-color", "chocolate");
                bankth3.Style.Add("background-color", "chocolate");
                kalemth3.Style.Add("background-color", "chocolate");
                kalemth4.Style.Add("background-color", "chocolate");
                kalemth5.Style.Add("background-color", "chocolate");
                kalemth6.Style.Add("background-color", "chocolate");
                kalemth7.Style.Add("background-color", "chocolate");
                kalemth8.Style.Add("background-color", "chocolate");
                kalemth2.Style.Add("background-color", "chocolate");
                kalemth1.Style.Add("background-color", "chocolate");
                kalemth10.Style.Add("background-color", "chocolate");
                kalemth11.Style.Add("background-color", "chocolate");
                invoiceinfotd1.Style.Add("background-color", "chocolate");
                invoiceinfotd2.Style.Add("background-color", "chocolate");
                invoiceinfotd3.Style.Add("background-color", "chocolate");
                invoiceinfotd4.Style.Add("background-color", "chocolate");
                invoiceinfotd5.Style.Add("background-color", "chocolate");
                invoiceinfotd6.Style.Add("background-color", "chocolate");
                invoiceinfotd7.Style.Add("background-color", "chocolate");
                kalem2th1.Style.Add("background-color", "chocolate");
                kalem2th2.Style.Add("background-color", "chocolate");
                kalem2th3.Style.Add("background-color", "chocolate");
                kalem2th4.Style.Add("background-color", "chocolate");
                kalem2th5.Style.Add("background-color", "chocolate");
            }

            else if (DropDownListHeaderColor.SelectedIndex == 5)
            {
                banktd1.Style.Add("background-color", "grey");
                bankth1.Style.Add("background-color", "grey");
                bankth2.Style.Add("background-color", "grey");
                bankth3.Style.Add("background-color", "grey");
                kalemth3.Style.Add("background-color", "grey");
                kalemth4.Style.Add("background-color", "grey");
                kalemth5.Style.Add("background-color", "grey");
                kalemth6.Style.Add("background-color", "grey");
                kalemth7.Style.Add("background-color", "grey");
                kalemth8.Style.Add("background-color", "grey");
                kalemth2.Style.Add("background-color", "grey");
                kalemth1.Style.Add("background-color", "grey");
                kalemth10.Style.Add("background-color", "grey");
                kalemth11.Style.Add("background-color", "grey");
                invoiceinfotd1.Style.Add("background-color", "grey");
                invoiceinfotd2.Style.Add("background-color", "grey");
                invoiceinfotd3.Style.Add("background-color", "grey");
                invoiceinfotd4.Style.Add("background-color", "grey");
                invoiceinfotd5.Style.Add("background-color", "grey");
                invoiceinfotd6.Style.Add("background-color", "grey");
                invoiceinfotd7.Style.Add("background-color", "grey");
                kalem2th1.Style.Add("background-color", "grey");
                kalem2th2.Style.Add("background-color", "grey");
                kalem2th3.Style.Add("background-color", "grey");
                kalem2th4.Style.Add("background-color", "grey");
                kalem2th5.Style.Add("background-color", "grey");
            }
        }


        protected void btnenterbankinfo_Click(object sender, EventArgs e)
        {
            if (Session["update"].ToString()==ViewState["update"].ToString())
            {
                StreamWriter yaz = new StreamWriter(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt",true);

                yaz.WriteLine(txtbxbankinfo1.Text + "," + txtbxbankinfo2.Text + "," + txtbxbankinfo3.Text);
                yaz.Close();

                var array = File.ReadAllLines(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt");

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
                var array = File.ReadAllLines(@"C:\Users\mcmac\Desktop\TURKKEP-InvoiceDesing\InvoiceDesingTest\images\bankinfo.txt");
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