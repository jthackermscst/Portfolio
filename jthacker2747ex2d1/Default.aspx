<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jthacker2747ex2d1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Comc2747 Exercise 2D : Vendor Address</h2>
        <p class="lead">Stored procedures, DB updates, transactions, Sql Parameters etc</p>
    </div>

    <div class="row">
        <div class="col-md-8">
            <div class="form-horizontal"> 
            
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Vendor:" CssClass="control-label col-sm-3"></asp:Label>
                    <asp:Label ID="addressIdLabel" runat="server" Text="Label" Visible="False"></asp:Label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="vendorDropDownList" runat="server"  CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="vendorDropDownList_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Account:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="accountNumberTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Name:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
               <div class="form-group">
                    <asp:Label ID="Label9" runat="server" Text="Address 1:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="address1TextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label10" runat="server" Text="Address 2:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="address2TextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label11" runat="server" Text="City:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="cityTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label12" runat="server" Text="State:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="stateTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label13" runat="server" Text="Zip:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="zipTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>


                 <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Credit rating:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="creditRatingDropDownList" runat="server"  CssClass="form-control" Width="5em">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text=" " CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:CheckBox ID="preferredVendorCheckBox" runat="server" Text="Preferred vendor" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text=" " CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:CheckBox ID="activeCheckBox" runat="server" Text="Active" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="Web service:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="purchasingWebSrvURLTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" Text="Modified Date:" CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:Calendar ID="modifiedDateCalendar" runat="server"></asp:Calendar>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label14" runat="server" Text=" " CssClass="control-label col-sm-3"></asp:Label>
                    <div class="col-sm-9">
                        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
                    </div>
                </div>
                

            </div>
        </div>
        <div class="col-md-4">
            <h3>Program Features</h3>
            <ul>
                <li>Stored Procedures</li>
                <li>DB updates</li>
                <li>Transactions</li>
                <li>SqlParameters</li>
                <li>Object-related mapping</li>
                <li>POCO Domain Classes</li>
                <li>Web interface</li>
                <li>Unbound controls (well, mostly...)</li>
            </ul>
        </div>
    </div>

</asp:Content>