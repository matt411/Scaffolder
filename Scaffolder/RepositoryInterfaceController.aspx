<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RepositoryInterfaceController.aspx.cs" Inherits="Scaffolder.RepositoryInterfaceController" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container body-content">
        <h1>ASP.NET MVC SCAFFOLDER</h1>
        <div class="row">
            <div class="col-md-4">
                <div class="well">
                    <div class="form-horizontal" role="form">
                        <div>
                            <%--<span class="label label-primary">Namespace</span>--%>
                            <asp:TextBox ID="TextBox1" runat="server" TabIndex="1" CssClass="text-muted" onFocus="javascript:this.select()">Namespace</asp:TextBox>
                        &nbsp;Just the project name. namespace ProjectName.Dal</div>
                        <div>
                            <%--<span class="label label-primary">Entity</span>--%>
                            <asp:TextBox ID="TextBox2" runat="server" TabIndex="2" CssClass="text-muted" onFocus="javascript:this.select()">Class or Entity</asp:TextBox>
                        &nbsp;The POCO Model</div>
                        <div>
                            <%--<span class="label label-primary">DbContext</span>--%>
                            <asp:TextBox ID="TextBox3" runat="server" TabIndex="3" CssClass="text-muted" onFocus="javascript:this.select()">DbContext</asp:TextBox>
                        &nbsp;The Name of the DbContext that holds your models.
                        </div>
                    </div>
                </div>
                <div class="well">
                    <div class="btn-block">
                        <div>
                            <asp:Button ID="Generate" runat="server" OnClick="Button1_Click" Text="GenerateCode" CssClass="btn-primary" TabIndex="4" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <div class="well ">
                    <span class="label-primary">Interface</span>
                    <pre class="prettyprint">
                    <asp:Label ID="Label2" runat="server" Text="Scaffold a Repositroy, Interface and Controller"></asp:Label>                       
                    </pre>
                   
            </div>
        </div>
    </div>
    </div>
</asp:Content>
