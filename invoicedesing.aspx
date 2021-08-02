<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="invoicedesing.aspx.cs" Inherits="InvoiceDesingTest.invoicedesing" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" aria-atomic="True">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="icon" href="images/titleimage.png"/>
<title>Invoice Desing - TÜRKKEP E-Base Portal</title>
   

    

    <style type="text/css">
        

 body {
    background-color: #FFFFFF;
    font-family: 'Tahoma', "Times New Roman", Times, serif;
    font-size: 11px;
    color:black !important; 
}
#BodyDiv{
    width:auto;
    overflow:auto;
    padding:10px;
    z-index:1;
    color:black;
}
#InvoiceDesingDiv{
    width:60%;
    z-index:2;
    float:left;
    padding:10px;
}
#DesingPanelDiv{
    width:35%;
    z-index:2;
    float:right;
}
#ServicerInfoDiv {
    width: 45%;
    height: auto;
    background-color: white;
    border-top: 4px solid black;
    border-bottom: 4px solid black;
    z-index: 3;
}
#CostumerInfoDiv {
    width: 45%;
    height: auto;
    background-color: white;
    z-index: 3;
    border-top: 4px solid black;
    border-bottom: 4px solid black;
    margin-top: 10px;
    float:left;
}

#EmptyInfoDiv {
    width: 45%;
    height:auto;
    background-color: white;
    z-index: 3;
    border-top: 4px solid black;
    border-bottom: 4px solid black;
    float: right;
    margin-top: 10px;
    margin-left:70px;
}

#GibLogoDiv {
    width: 100px;
    height: 100px;
    padding: 5px;
    z-index: 3;
    float: right;
    margin-top: 20px;
    margin-right: 20px;
}
#CompanyLogoDiv {
    width: 100px;
    height: 100px;
    padding: 5px;
    z-index: 3;
    float: right;
    margin-top: 20px;
}
#EmptyLogoDiv {
    width: 100px;
    height: 100px;
    padding:5px;
    z-index: 3;
    float: right;
    margin-top: 20px;
    margin-right: 20px;
}

#EmptyLogoDiv2 {
    width:250px;
    height:130px;
    padding: 5px;
    z-index: 3;
    float: right;
    margin-top:20px;
    margin-right:30px;
}





.hovered {
    border: dotted 5px black;
}

.invisible {
    display: none;
}

.held {
    border: solid 10px black;
    background-color: black;
}

#InvoiceInfoTable {
    float:left;
    border-collapse: collapse;
    z-index: 3;
    background-color: white;
}

#InvoiceInfoTable td {
    width:110px;
}


#InvoiceCostDiv {
    z-index: 3;
    width: 100%;
    margin-top:200px;
}

#InvoiceCost1Table {
    width: 100%;
    border-collapse: collapse;
    text-align: center;
    z-index: 3;
    background-color: white;
}

#InvoiceCostDiv2 {
    z-index: 3;
    width: 100%;
}

#InvoiceCost2Table {
    width: 50%;
    border-collapse: collapse;
    text-align: center;
    float: right;
    z-index: 3;
    background-color: white;
}
#InvoiceCost2Table th{
    width:65%;
}
    #InvoiceCost2Table td {
        width: 35%;
    }


#BankInfo{
    width:100%;
    margin-top:100px;
}
#BankInfoTable {
    width: 100%;
    border-collapse: collapse;
    text-align: center;
    z-index: 3;
    background-color: white;
    
}


    #EditorTable {
        width: 100%;
    }


.thstyle {
    background-color: green;
}
#InvoiceInfoDiv{
    width:250px;
    height:200px;
    float:left;
    margin-top:50px;
}





        .auto-style1 {
            width: 29px;
        }
        .auto-style2 {
            width: 8px;
        }
        .auto-style3 {
            width: 114px;
        }
        .otoconfig{
            width:136px;
        }
        
        .auto-style4 {
            height: 20px;
        }
        
        .auto-style5 {
            width: 80px;
        }
        
    </style>
</head>
    
<body>
    <form id="form1" runat="server"> 
        <div id="BodyDiv" runat="server" style="font-size: 11px; font-family:Tahoma,'Times New Roman'"> 


                     <div id="InvoiceDesingDiv" runat="server">

                  <div id="CompanyLogoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)">
                      <img  src="images/placeholder.png" runat="server" id="ImageCompanyLogo" style="width:100px; height:100px;background-color:#666666" draggable="true"
ondragstart="drag(event)"/>
                      
                  </div>

                 
                
                 <div id="GibLogoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)">
                     
                      <img src="images/untitled.png" id="ImageGibLogo" runat="server" style="height:100px;width:100px" draggable="true"
ondragstart="drag(event)"/> 
                  </div>


                 <div id="EmptyLogoDiv" ondrop="drop(event)" ondragover="allowDrop(event)">
                      
                 </div>



                  <div id="ServicerInfoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)"> <!--It contains servicer company information-->
                      <table id="ServicerInfoTable" runat="server" draggable="true" ondragstart="drag(event)">

                          <tr> <td><b>TÜRKKEP A.Ş</b></td> </tr>
                          <tr> <td>Sümer Sok.a Ayazağa Ticaret Merkezi No:3 Maslak / İSTANBUL </td> </tr>
                          <tr> <td>Tel: (222) 236 91 31 Fax: (850) 470 53 70 </td> </tr>
                          <tr> <td>Web Sitesi: www.mngkargo.com.tr</td> </tr>
                          <tr> <td>E-Posta: info@mngkargo.com.tr</td> </tr>
                          <tr> <td>Vergi Dairesi: BÜYÜK MÜKELLEFLER VD.BŞK.LIĞI </td> </tr>
                          <tr> <td>MERSISNO: 0622034422034422</td> </tr>
                          <tr> <td>TICARETSICILNO: s123</td> </tr>
                          <tr> <td>VKN: 6080475329</td> </tr>
                          
                      </table>
                  </div>

                         

                 <div id="EmptyInfoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)"> <!--It contains servicer company information-->
                     
                  </div>


                 





                


                  <div id="CostumerInfoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)"> <!--It contains costumer/costumer company information-->
              <table id="CostumerInfoTable" runat="server" draggable="true" ondragstart="drag(event)">

                          <tr> <td><b>ÜSKÜDAR ÜNİVERSİTESİ</b></td> </tr>
                          <tr> <td>Sümer Sok.a Ayazağa Ticaret Merkezi No:3 Altunizade / İSTANBUL </td> </tr>
                          <tr> <td>Tel: (222) 578 23 26 Fax: (850) 371 43 79 </td> </tr>
                          <tr> <td>Web Sitesi: www.uskudaruniversitesi.com.tr</td> </tr>
                          <tr> <td>E-Posta: info@uskudaruniversitesi.com.tr</td> </tr>
                          <tr> <td>Vergi Dairesi: BÜYÜK MÜKELLEFLER VD.BŞK.LIĞI </td> </tr>
                          <tr> <td>MERSISNO: 0622034422034422</td> </tr>
                          <tr> <td>TICARETSICILNO: s123</td> </tr>
                          <tr> <td>VKN: 6080475329</td> </tr>

                      </table>
                  </div>

                  <div id="EmptyLogoDiv2" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)">
                      
                 </div>


                 


                <div id="InvoiceCostDiv" runat="server">
                    <table id="InvoiceCost1Table" border="1" runat="server">
                        <tr> 
                            <th class="auto-style2" id="kalemth1" runat="server">Sıra No</th> <th class="auto-style3" id="kalemth2" runat="server">Mal Hizmet</th> <th runat="server" id="kalemth3">Miktar</th> <th runat="server" id="kalemth4">Birim Fiyat</th>
                            <th runat="server" id="kalemth5">İskonto Oranı</th> <th  runat="server" id="kalemth6">İskonto Tutarı</th> <th  runat="server" id="kalemth7">KDV Oranı</th> <th runat="server" id="kalemth11">KDV Tutarı</th>
                            <th  runat="server" id="kalemth8">Diğer Vergiler</th> <th class="otoconfig" runat="server" id="kalemth10">Mal Hizmet Tutarı</th>
                        </tr>

                         <tr> 
                            <td class="auto-style2">1</td> <td class="auto-style3">test</td> <td>test</td> <td>33</td>
                            <td>50TL</td> <td></td> <td> %10,00</td> <td></td>
                            <td></td> <td> 600,00 TL</td>
                        </tr>
                    </table>

                    <div id="InvoiceInfoDiv" runat="server" ondrop="drop(event)" ondragover="allowDrop(event)">
                         <table id="InvoiceInfoTable" border="1" runat="server" draggable="true" ondragstart="drag(event)">
                         <tr> <td id="invoiceinfotd1" runat="server" style="font-weight:bold">Özelleştirme No:</td> <td>TR1.2</td> </tr>
                         <tr> <td id="invoiceinfotd2" runat="server" style="font-weight:bold" class="auto-style1">Senaryo:</td> <td>TICARIFATURA</td> </tr>
                         <tr> <td id="invoiceinfotd3" runat="server" style="font-weight:bold">Fatura Tipi:</td> <td>SATIS</td> </tr>
                         <tr> <td id="invoiceinfotd4" runat="server" style="font-weight:bold">Fatura No:</td> <td></td> </tr>    
                         <tr> <td id="invoiceinfotd5" runat="server" style="font-weight:bold">Fatura Tarihi:</td> <td>12-10-2018</td> </tr>
                         <tr> <td id="invoiceinfotd6" runat="server" style="font-weight:bold">Sipariş No:</td> <td>1234</td> </tr>
                         <tr> <td id="invoiceinfotd7" runat="server" style="font-weight:bold">Sipariş Tarihi:</td> <td>11-10-2018</td> </tr>
                     </table>
                    </div>
                    




                    <table id="InvoiceCost2Table" border="1" runat="server">
                         <tr> <th runat="server" id="kalem2th1">Mal Hizmet Toplam Tutarı</th> <td>600,00 TL</td> </tr>
                         <tr> <th runat="server" id="kalem2th2">Toplam İskonto</th> <td>0,00 TL</td> </tr>
                         <tr> <th runat="server" id="kalem2th3">Hesaplanan GERÇEK USULDE KATMA DEĞER VERGİSİ (%10.00)</th> <td>60,00 TL</td> </tr>
                         <tr> <th runat="server" id="kalem2th4">Vergiler Dahil Toplam Tutar</th> <td>660,00 TL</td> </tr>
                         <tr> <th runat="server" id="kalem2th5">Ödenecek Tutar</th> <td>660,00 TL</td> </tr>
                     </table>
                 </div>



                

                 <div id="BankInfo" runat="server">
                      
                     <table border="1" id="BankInfoTable" runat="server">
                      <tr>
                          <td colspan="4" runat="server" id="banktd1">
                              <h3>BANKA HESAP BİLGİLERİMİZ</h3>

                          </td>

                      </tr>
                          <tr>
                            <th style="width: 150px" id="bankth1" runat="server">
                              BANKA ADI
                            </th>
                            <th style="width: 180px" id="bankth2" runat="server">
                              ŞUBE KODU
                            </th>
                           
                            <th style="width: 260px" id="bankth3" runat="server">
                              IBAN
                            </th>
                          </tr>
                         
                          <tr>
                            <td>YAPIKREDİ  TL</td>
                            <td>(917)</td>
                            <td>TR83 0006 7010 0000 0071 4570 49</td>
                          </tr>
						  <tr>
                            <td>YAPIKREDİ  USD</td>
                            <td>(917)</td>
                            <td>TR51 0006 7010 0000 0071 5117 51</td>
                          </tr>

                        </table>
                 </div>

             </div>  <!--Invoice desing preview div-->
                 

             <div id="DesingPanelDiv" runat="server">
                 
                 <table id="EditorTable" runat="server">
                     <tr> 
                         <td>
                             <asp:Label ID="Label1" runat="server" Text="Template Color :"></asp:Label></td>
                         <td>
                             <asp:DropDownList ID="DropDownListColor" runat="server">
                                 <asp:ListItem>Black</asp:ListItem>
                                 <asp:ListItem>Grey</asp:ListItem>
                                 <asp:ListItem>Brown</asp:ListItem>
                                 <asp:ListItem>Green</asp:ListItem>
                                 <asp:ListItem>Blue</asp:ListItem>
                                 <asp:ListItem>Chocolate</asp:ListItem>
                             </asp:DropDownList>
                             <asp:Label ID="lblcheckcolor" runat="server" Visible="False" Font-Size="Small" ForeColor="Red"></asp:Label></td>
                         <td class="auto-style5">
                             <asp:Label ID="Label2" runat="server" Text="Headers Color :"></asp:Label></td>
                         <td> <asp:DropDownList ID="DropDownListHeaderColor" runat="server">
                             <asp:ListItem>White</asp:ListItem>
                             <asp:ListItem>Brown</asp:ListItem>
                             <asp:ListItem>Green</asp:ListItem>
                             <asp:ListItem>Blue</asp:ListItem>
                             <asp:ListItem>Chocolate</asp:ListItem>
                             <asp:ListItem>Grey</asp:ListItem>
                             </asp:DropDownList></td>

                         <td>
                             <asp:Button ID="BtnApplyColor" runat="server" Text="Apply" OnClick="BtnApplyColor_Click"/></td>

                     </tr>



                   


                     <tr>
                         <td><br /><br /><br /><asp:Label ID="Label3" runat="server" Text="Logo :"></asp:Label></td> 

                         <td><br /><br /><br /> <asp:FileUpload ID="FileUploadLogo" runat="server" Width="188px" /></td>
                         <td class="auto-style5"><br /><br /><br /><asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="btnUpload_Click" /></td>
                          <td></td> 
                          <td></td>
                     </tr>
                     
                     <tr>

                         <td colspan="4" class="auto-style4">

                             <asp:Label ID="lbluploadimageerror" runat="server" Visible="False" Font-Size="Small" ForeColor="Red"></asp:Label></td>
                     </tr>
                     
                     
                     <tr>
                         <td colspan="3">
                             <br />
                             <br /><br /><br />
                             <asp:Label ID="Label4" runat="server" Text="Add Banking Info :" Font-Bold="true"></asp:Label>
                             
                         </td>
                        
                     </tr>

                     <tr>
                        <td colspan="3">
                            <asp:Label ID="Label5" runat="server" Text="Banka Adı :"></asp:Label> &nbsp;&nbsp;<asp:TextBox ID="txtbxbankinfo1" runat="server" Width="200px"></asp:TextBox></td> </tr>

                     <tr>
                        <td colspan="3">
                            <asp:Label ID="Label6" runat="server" Text="Şube Kodu :"></asp:Label> &nbsp;<asp:TextBox ID="txtbxbankinfo2" runat="server" Width="200px"></asp:TextBox>&nbsp;</td> </tr>

                      <tr>
                          
                        <td colspan="3">
                            <asp:Label ID="Label7" runat="server" Text="IBAN :"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbxbankinfo3" runat="server" Width="200px"></asp:TextBox></td> </tr>

                     <tr>
                        <td><asp:Button ID="btnenterbankinfo" runat="server" Text="Enter" OnClick="btnenterbankinfo_Click"/> </td></tr>


                   

                 </table>

                 <br />
                 <br />
                 <br />

                  
                     
                     <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                     
                     <button id="save-btn" onclick="onClick()">FINISH AND SHOW HTML SOURCE</button>

                 
                 
                 <a href="images/bankinfo.txt">images/bankinfo.txt</a>
                 <br />
                 <br />
                 <br />


             </div>  <!--It contains items for desing of invoice-->
              
                   


        </div> <!--It contains all page-->
        



    </form>

        <textarea id="textbox">Paste Html Source</textarea> <button id="create">Create file</button> <a download="test.html" id="downloadlink" style="display: none" onclick="afterDownload()">Download</a>
    <br />
    <br />

    <asp:Label ID="lblhtmloutput" runat="server" Text="htmloutput"></asp:Label>
    
    <script type="text/javascript" src="invoicestyle.js"></script>

  
</body>
</html>
