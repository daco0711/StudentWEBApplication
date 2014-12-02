<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebApplicationStudent._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>

    <h2>
    Broj studenata u bazi: <asp:Label ID = "LblCount" runat = "server" BorderStyle = "Double" />
    </h2>
    <p>
        <asp:Label ID="statusLbl" runat="server"></asp:Label>
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>

    <p>
    <asp:Button ID = "BtnTrazi" runat ="server" Text = "Search" OnClick ="getStudentById"/> <asp:TextBox ID="txtSearch" runat ="server"></asp:TextBox>
    </p>

    <p>
    
    <asp:Button ID = "btnUpdate" runat = "server" Text="Update" OnClick = "updateStudent" />
    </p>

    <p>
    <asp:Label ID = "lblUpIme" runat = "server" Text = "Ime"></asp:Label>
    <asp:TextBox ID = "txtUpdIme" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdIndexNumber" runat = "server" Text = "IndexNumber"></asp:Label>
    <asp:TextBox ID = "txtUpdIndexNumber" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblJMBG2" runat = "server" Text = "JMBG"></asp:Label>
    <asp:TextBox ID = "txtUpdJMBG" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdCity" runat = "server" Text = "City"></asp:Label>
    <asp:TextBox ID = "txtUpdCity" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdAddress" runat = "server" Text = "Address"></asp:Label>
    <asp:TextBox ID = "txtUpdAddress" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdSex" runat = "server" Text = "Sex"></asp:Label>
    <asp:TextBox ID = "txtUpdsex" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdDatum" runat = "server" Text = "Datum"></asp:Label>
    <asp:TextBox ID = "txtUpdDatum" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblUpdID" runat = "server" Text = "ID"></asp:Label>
    <asp:TextBox ID = "txtUpdID" runat = "server"></asp:TextBox>
    
    
    </p>

    <p>
    
    <asp:Label ID = "lblIme" runat = "server" Text = "Ime"></asp:Label>
    <asp:TextBox ID = "txtDodajIme" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblbrIndexa" runat = "server" Text = "IndexNumber"></asp:Label>
    <asp:TextBox ID = "txtBrIndexa" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblJmbg" runat = "server" Text = "JMBG"></asp:Label>
    <asp:TextBox ID = "txtJmbg" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblCity" runat = "server" Text = "City"></asp:Label>
    <asp:TextBox ID = "txtCity" runat = "server"></asp:TextBox>
    </p>
    
    <p>
    <asp:Label ID = "lblDodajAdresu" runat = "server" Text = "Address"></asp:Label>
    <asp:TextBox ID = "txtDodajAdresu" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblSex" runat = "server" Text = "Sex"></asp:Label>
    <asp:TextBox ID = "txtDodajSex" runat = "server"></asp:TextBox>
    <asp:Label ID = "lblDodajDatum" runat = "server" Text = "Datum"></asp:Label>
    <asp:TextBox ID = "txtDatum" runat = "server"></asp:TextBox>
    </p>
    
    <asp:Button ID = "btnDodaj" runat = "server" OnClick = "addStudent" Text = "Dodaj" />
    
    

    <p>

    <asp:Button ID = "btnDel" runat ="server" Text = "Delete" OnClick ="delStudents"/> <asp:TextBox ID="txtDel" runat ="server"></asp:TextBox>

    </p>

    <p>
    <asp:Table ID = "IDTabele" runat ="server" HorizontalAlign = "Center" BorderColor = "Red" Height = "3px">
        <asp:TableHeaderRow BackColor = "Black" ForeColor = "Red" Width = "100%">
        <asp:TableHeaderCell Width = "20%">Ime</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">JMBG</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">ID</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">IndexNumber</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">City</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">Address</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">Pol</asp:TableHeaderCell>
        <asp:TableHeaderCell Width = "20%">DatumRodjenja</asp:TableHeaderCell>
        
  </asp:TableHeaderRow>
  </asp:Table>

    </p>
</asp:Content>
