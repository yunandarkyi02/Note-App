<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Notes.aspx.cs" Inherits="NoteAppproject.Notes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Notes.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
<div class="container"> 
<h1>Notes</h1>
<input type="text" id="title" placeholder="Enter a Title..."/><br />
    <input type="text" id="notes_input" placeholder="Enter a note..."/>


<button type="submit">Add</button>
    <asp:Button ID="Button" runat="server" Text="Add" OnClick="Button_Click" />
<ul id="notes"></ul>
</div>
        <script src="app.js"></script>
    </form>
</body>
</html>
