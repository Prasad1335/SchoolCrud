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
        <div>
            <table class="alert alert-success ml-5 mt-5">
                <h4 class="bg-dark text-info p-3">View All Student</h4>
                <tr><td>
                    <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label><br />
                    <asp:TextBox ID="TextBoxName" CssClass="form-control"  placeholder="enter Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td>
                    <asp:Label ID="LabelRollNo" runat="server" Text="RollNo"></asp:Label><br />
                    <asp:TextBox ID="TextBoxRollNo" CssClass="form-control" placeholder="enter RollNo" runat="server"></asp:TextBox>
                </td></tr>
                <tr><td>
                    <asp:Label ID="LabelAddress" runat="server" Text="Address"></asp:Label><br />
                    <asp:TextBox ID="TextBoxAddress" CssClass="form-control" placeholder="enter Address" runat="server"></asp:TextBox><br />
                </td></tr>
                 <tr><td>
                     <asp:Button ID="Button1" runat="server"  CssClass="form-control" class="btn btn-warning" Text="Submit" onClick="Submit_Click"/>
                     <a class="btn btn-primary" href="DisplayAll.aspx">Back to list</a>
                </td></tr>
            </table>
        </div>
    </form>
</body>
</html>
