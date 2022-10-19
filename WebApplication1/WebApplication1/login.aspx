<%@ Page Title="" Language="C#" MasterPageFile="~/login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div id="loginbox" style="margin-top: 50px;" class="mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2">
            <div class="panel panel-info">
                <div class="panel-heading">
                    <div class="panel-title">Kullanıcı Girişi</div>
                </div>

                <div style="padding-top: 30px;" class="panel-body">

                    <form id="loginform" class="form-horizontal" role="form">

                        <div style="margin-bottom: 25px; position: relative; top: 20%; left: 20%;" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
                            <asp:TextBox ID="loginusername" class="form-control" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
                        </div>

                        <div style="margin-bottom: 25px; position: relative; top: 20%; left: 20%;" class="input-group">
                            <span class="input-group-addon"><i class="glyphicon glyphicon-lock"></i></span>
                            <asp:TextBox ID="loginpassword" type="password" class="form-control" runat="server" placeholder="Şifre"></asp:TextBox>
                        </div>

                        <div style="margin-top: 10px; position: relative; top: 20%; left: 40%;" class="form-group">
                            <!-- Button -->
                            <div class="col-sm-12 controls">
                                <asp:Button ID="btnlogin" OnClick="btnlogin_Click1" class="btn btn-success" runat="server" Text="Giriş Yap" />
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
