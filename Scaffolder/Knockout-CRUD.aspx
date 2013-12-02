<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Knockout-CRUD.aspx.cs" Inherits="Scaffolder.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container body-content">
        <h1>Knockout CRUD</h1>
        <div class="row">
            <div class="col-md-4">
                <div class="well">
                    <div class="form-horizontal" role="form">
                        <div>
                            <%--<span class="label label-primary">Namespace</span>--%>
                            <asp:TextBox ID="TextBox2" runat="server" TabIndex="1" CssClass="text-muted"  >Entity</asp:TextBox>
                            <br />
                            This will also be used for the Id... ProductId
                        </div>
                        <div>
                            <%--<span class="label label-primary">Entity</span>--%>
                            <asp:TextBox ID="TextBox1" runat="server" TabIndex="2" CssClass="text-muted"  >Property2 </asp:TextBox>
                        </div>
                        <div>
                            <%--<span class="label label-primary">DbContext</span>--%>
                            <asp:TextBox ID="TextBox4" runat="server" TabIndex="3" CssClass="text-muted"  >Property3</asp:TextBox>
                        </div>
                        <div>
                            <%--<span class="label label-primary">DbContext</span>--%>
                            <asp:TextBox ID="TextBox5" runat="server" TabIndex="4" CssClass="text-muted"  >Property4</asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="well">
                    <div class="btn-block">
                        <div>
                            <asp:Button ID="ButtonJsonController" runat="server" OnClick="Button1_Click" Text="Knockout CRUD" CssClass="btn-default" TabIndex="5" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <div class="well ">
                    <%--<asp:Label ID="Label1" runat="server" Text="Complete the fields to generate a Knockout View Model and View with CRUD functions in a single cshtml document. " CssClass="panel-heading" ClientIDMode="AutoID" EnableViewState="False"></asp:Label>--%>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="prettyprint" Height="250px" TextMode="MultiLine" Width="100%"></asp:TextBox>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
