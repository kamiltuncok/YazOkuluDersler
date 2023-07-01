<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="form1" runat="server">
        <div class="form-group">
  
            <strong>
            <asp:Label for="Txtid" runat="server" Text="Öğrenci ID:"></asp:Label>
            <asp:TextBox ID="txtid" runat="server" CssClass="form-control"></asp:TextBox>
           </strong>
            <br />
           <strong>
            <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı:"></asp:Label>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
           </strong>
            <br />
        </div>

        <div class="form-group">

            <strong>

            <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="form-group">

            <strong>

            <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="form-group">

            <strong>

            <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="form-group">

            <strong>

            <asp:Label for="TxtFotograf" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
            </strong>
            <asp:TextBox ID="TxtFotograf" runat="server" CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <asp:Button ID="btnguncelle" runat="server" Text="Güncelle"  CssClass="btn btn-dark" OnClick="btnguncelle_Click" />
    </form>
</asp:Content> 



