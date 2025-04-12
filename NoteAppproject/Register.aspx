<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NoteAppproject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Register </title>
    <link href="Style.css" rel="stylesheet" />
     
</head>
<body>
    <form id="form1" runat="server">
  <div class="container">
    <h1>Register</h1>
    <p>Please fill in this form to create an account.</p>
    <hr/>

    <label for="name"><b>Name</b></label>
    <input type="text" placeholder="Enter Name" name="name" id="name" required=""/>
      <br />
           <label for="email"><b>Email</b></label>
    <input type="text" placeholder="Enter Email" name="email" id="email" required=""/><br />


    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="password" id="password" required=""/><br />

    <label for="psw-repeat"><b>Repeat Password</b></label>
    <input type="password" placeholder="Repeat Password" name="psw-repeat" id="psw-repeat" required=""/><br />
    <hr/>

    <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.
      </p>
    
      <asp:Button ID="Button1" runat="server" Text="Register" class="registerbtn" OnClick="Button1_Click"/>
      <asp:Button ID="Button2" runat="server" Text="Cancel" class="registerbtn" OnClick="Button2_Click"/>
  </div>

  <div class="container signin">
    <p>Already have an account? <a href="Login.aspx">Sign in</a>.</p>
  </div>
    </form>
</body>
</html>
