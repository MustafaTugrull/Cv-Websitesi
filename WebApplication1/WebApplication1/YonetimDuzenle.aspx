<%@ Page Title="" Language="C#" MasterPageFile="~/login.Master" AutoEventWireup="true" CodeBehind="YonetimDuzenle.aspx.cs" Inherits="WebApplication1.WebForm7" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">İçerik Düzenle</div>
                </div>

                <div style="padding-top: 30px;" class="panel-body">

                    <form id="loginform" class="form-horizontal" role="form">

                        <div style="margin-bottom: 25px; position: relative; top: 20%; left: 20%;" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-th-list"></i></span>
                            <asp:TextBox ID="Icerik1" class="form-control" runat="server" placeholder="İçerik" Enabled="false"></asp:TextBox>
                        </div>

                        <div style="margin-bottom: 25px; position: relative; top: 20%; left: 20%;" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-tag"></i></span>
                            <asp:TextBox ID="Title1" class="form-control" runat="server" placeholder="Başlık" Enabled="false"></asp:TextBox>
                        </div>

                        <div style="margin-bottom: 25px; position: relative; top: 20%; left: 20%;" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-font"></i></span>
                            <asp:TextBox ID="Metin1" class="form-control" runat="server" placeholder="Metin"></asp:TextBox>
                        </div>

                        <div style="margin-top: 10px; position: relative; top: 20%; left: 30%;" class="form-group">
                            <!-- Button -->
                            <div class="col-sm-2 controls">
                                <asp:Button ID="btnlogin" OnClick="btnDuzenle_Click1" class="btn btn-success" runat="server" Text="Kaydet" />
                            </div>
                            <div class="col-sm-1 controls">
                                <asp:Button ID="Iptal1" OnClick="btnIptal_Click1" class="btn btn-success" runat="server" Text="İptal" />
                            </div>
                        </div>

                        <script src="./assets/js/bootstrap.min.js"></script>
                        <script src="./assets/js/vendor/modernizr-3.5.0.min.js"></script>
                        <script src="./Scripts/jquery-3.4.1.min.js"></script>
                        <script src="./Scripts/WebForms/MSAjax"></script>

                    </form>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
