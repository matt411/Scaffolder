<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Scaffolder.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container body-content">
        <h1>ASP.NET MVC SCAFFOLDER</h1>
        <div class="row">
            <div class="col-md-4">
                <div class="well">
                    <div class="form-horizontal" role="form">
                        <div>
                            <%--<span class="label label-primary">Namespace</span>--%>
                            <asp:TextBox ID="TextBox2" runat="server" TabIndex="1" CssClass="text-muted"  >Namespace</asp:TextBox>
                        </div>
                        <div>
                            <%--<span class="label label-primary">Entity</span>--%>
                            <asp:TextBox ID="TextBox1" runat="server" TabIndex="2" CssClass="text-muted"  >Entity</asp:TextBox>
                        </div>
                        <div>
                            <%--<span class="label label-primary">DbContext</span>--%>
                            <asp:TextBox ID="TextBox3" runat="server" TabIndex="3" CssClass="text-muted"  >DbContext</asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="well">
                    <div class="btn-block">
                        <div>
                            <asp:Button ID="ButtonJsonController" runat="server" OnClick="Button1_Click" Text="Json Controller" CssClass="btn-default" TabIndex="4" />
                        </div>
                        <div>
                            <asp:Button ID="Button2" runat="server" CssClass="btn-default" Text="EntityRepository" OnClick="Button2_Click" TabIndex="5" />
                        </div>
                        <div>
                            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="IEntityRepository (Unit of Work)" CssClass="btn-default" TabIndex="6" />
                        </div>
                         <div>
                            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Repo, Interface, Controller" CssClass="btn-default" TabIndex="7" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <div class="well ">
                    <pre class="lang-cs prettyprint prettyprinted"><code><asp:Label ID="Label1" runat="server" Text="Complete the fields and select the code to generate." CssClass="active left" ClientIDMode="AutoID" EnableViewState="False"></asp:Label></code>
                    </pre>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
