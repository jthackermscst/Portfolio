<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="jthacker2747ex1f1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">COMC2747 Exercise 1F</p>
    </div>

    <div class="row">
        <div class="form-horizontal">
            <div class="col-md-8">
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Vendor:" CssClass="form-control"></asp:Label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="vendorDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="vendorDropDownList_SelectedIndexChanged"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Purchase Order:" CssClass="form-control"></asp:Label>
                    <div class="col-sm-9">
                        <asp:DropDownList ID="purchaseOrderIdDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="purchaseOrderIdDropDownList_SelectedIndexChanged"></asp:DropDownList>
                </div>
                <div class="form-group">
                     
               </div>
                <div class="form-group">
                     <asp:Label ID="Label3" runat="server" Text="Revision number:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                          <asp:TextBox ID="revisionNumberTextBox" runat="server" ></asp:TextBox>
                    </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label4" runat="server" Text="Status:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                          <asp:TextBox ID="statusTextBox" runat="server" ></asp:TextBox>
                    </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label9" runat="server" Text="Employee ID:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                          <asp:TextBox ID="employeeIDTextBox" runat="server" ></asp:TextBox>
                    </div>
               </div>
              <div class="form-group">
                     <asp:Label ID="Label5" runat="server" Text="Employee Name:" CssClass="form-control"></asp:Label>
                     <div class="col-sm-9">
                         <asp:DropDownList ID="employeeNameDropDownList" runat="server" OnSelectedIndexChanged="employeeNameDropDownList_SelectedIndexChanged"></asp:DropDownList>
                     </div>
               </div>
               <%--<div class="form-group">
                     <asp:Label ID="Label5" runat="server" Text="Ship method ID:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                          <asp:TextBox ID="shipMethodIdTextBox" runat="server" ></asp:TextBox>
                    </div>
               </div>--%>
             <div class="form-group">
                     <asp:Label ID="Label10" runat="server" Text="Ship method:" CssClass="form-control"></asp:Label>
                     <div class="col-sm-9">
                         <asp:DropDownList ID="shipMethodDropDownList" runat="server"></asp:DropDownList>
                     </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label6" runat="server" Text="Ship date:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                          <asp:TextBox ID="shipDateTextBox" runat="server" ></asp:TextBox>
                    </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label13" runat="server" Text="Order details:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                         <asp:GridView ID="purchaseOrderDetailsGridView" runat="server" AutoGenerateColumns="False" CssClass="table-bordered table-hover" >
                             <Columns>
                                 <asp:BoundField DataField="PurchaseOderID" HeaderText="PurchaseOrderID" Visible="False" />
                                 <asp:BoundField DataField="PurchaseOrderDetailID" HeaderText="DetID" >
                                 <HeaderStyle Width="4em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="DueDate" HeaderText="Due Date" DataFormatString="{0:MM/dd/yyyy}" >
                                 <HeaderStyle Width="8em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="OrderQty" HeaderText="OrderQty" DataFormatString="{0:N0}" >
                                 <HeaderStyle Width="3em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="ProductID" HeaderText="ProdID" >
                                 <HeaderStyle Width="4em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" DataFormatString="{0:C2}" >
                                 <HeaderStyle Width="8em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="LineTotal" HeaderText="Line Total" DataFormatString="{0:C2}" >
                                 <HeaderStyle Width="8em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="ReceivedQty" HeaderText="Rec" DataFormatString="{0:N0}" >
                                 <HeaderStyle Width="3em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="RejectedQty" HeaderText="Rej" DataFormatString="{0:N0}" >
                                 <HeaderStyle Width="3em" />
                                 </asp:BoundField>
                                 <asp:BoundField DataField="StockedQty" HeaderText="Stocked" DataFormatString="{0:N0}" >
                                 <HeaderStyle Width="3em" />
                                 </asp:BoundField>
                             </Columns>
                         </asp:GridView>
                     </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label7" runat="server" Text="Subtotal:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                         <asp:Label ID="subtotalLabel" runat="server" BorderStyle="Solid"></asp:Label>
                     </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label8" runat="server" Text="Tax:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                         <asp:Label ID="taxAmtLabel" runat="server" BorderStyle="Solid"></asp:Label>
                     </div>
               </div>
               <div class="form-group">
                      <asp:Label ID="Label11" runat="server" Text="Freight:" CssClass="control-label col-sm-3"></asp:Label>
                      <div class="col-sm-9">
                           <asp:TextBox ID="freightTextBox" runat="server" ></asp:TextBox>
                      </div>
               </div>
               <div class="form-group">
                     <asp:Label ID="Label12" runat="server" Text="Total Due:" CssClass="control-label col-sm-3"></asp:Label>
                     <div class="col-sm-9">
                         <asp:Label ID="totalDueLabel" runat="server" BorderStyle="Solid"></asp:Label>
                     </div>
               </div>
              </div>                   
          </div>
    
    
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
       </div>
    </div>

</asp:Content>
