<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayAll.aspx.cs" Inherits="SchoolCrud.pages.DisplayAll" %>

<%@ Import Namespace="School.Services" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display All Student</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" />
    <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row p-5 alert alert-warning border border-warning mt-5">
                <div class="col-12 col-md-12 col-sm-12 col-lg-12 mb-3">
                    <a class="btn btn-outline-danger mb-3" href="Add.aspx">Add New Student</a>
                    <h4 class="bg-dark text-info p-3">View Student List</h4>
                </div>
                <div class="col-12  col-md-12 col-sm-12 col-lg-12" style="overflow-x:auto">
                    <table class="table table-bordered table-hover table-striped">
                        <tr class="bg-warning">
                            <th>id</th>
                            <th>name</th>
                            <th>rollno</th>
                            <th>address</th>
                            <th>update</th>
                            <th>Delete</th>
                        </tr>
                        <%
                            var ser = new StudentServices();
                            var stud = ser.GetAll();
                            foreach (var st in stud)
                            {
                        %>
                        <tr class="text-center">
                            <td><%= st.Id%></td>
                            <td><%= st.Name %></td>
                            <td><%= st.RollNo%></td>
                            <td><%= st.Address %></td>
                            <td class="alert alert-info"><a class="btn btn-outline-info mb-3" href="Update.aspx?id=<%=st.Id %>">Edit</a></td>
                            <td class="alert alert-danger"><a class="btn btn-outline-danger mb-3" href="Delete.aspx?id=<%=st.Id %>">Delete</a></td>
                        </tr>
                        <%
                            }
                        %>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
