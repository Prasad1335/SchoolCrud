<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="SchoolCrud.pages.Add" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add new Student</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row p-5 alert alert-success border border-success mt-5">
                <div class="col-12 col-md-12 col-sm-12 col-lg-12 mb-3">
                    <h4 class="bg-dark text-info p-3">Add new Student</h4>
                </div>
                <div class="col-6 col-md-6col-sm-6 col-lg-6">
                    <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label><br />
                    <asp:TextBox ID="TextBoxName" CssClass="form-control  mt-2 mb-2" placeholder="enter Name" runat="server"></asp:TextBox>
                </div>
                <div class="col-6 col-md-6col-sm-6 col-lg-6">
                    <asp:Label ID="LabelRollNo" runat="server" Text="RollNo"></asp:Label><br />
                    <asp:TextBox ID="TextBoxRollNo" CssClass="form-control mt-2 mb-2" placeholder="enter RollNo" runat="server"></asp:TextBox>
                </div>
                <div class="col-6 col-md-6col-sm-6 col-lg-6">
                    <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label><br />
                    <asp:TextBox ID="TextBoxAddress" CssClass="form-control mt-2" placeholder="enter Address" runat="server"></asp:TextBox><br />
                </div>
                <div class="col-6 col-md-6"></div>
                <div class="col-12 col-md-12 col-sm-12 col-lg-12 mt-2 ">
                    <asp:Button ID="Button1" runat="server" class="form-control btn btn-success mb-3" Text="Submit" OnClick="Submit_Click_Create" />
                    <a class="btn btn-primary float-right" href="DisplayAll.aspx">Back to list</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
