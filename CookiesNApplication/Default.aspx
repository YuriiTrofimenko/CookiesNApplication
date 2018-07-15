<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CookiesNApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="/wwwroot/style.css" />
</head>
<body>
    <form id="form1" runat="server" method="get">
        <div runat="server" id="subscriptionForm">
            <label for="name">Name:</label>
            <input id="name" name="name" placeholder="Your name" />
            <label for="email">E-mail:</label>
            <input id="email" name="email" placeholder="Your email" />
            <input id="lastname" name="lastname" placeholder="Lastname"/>
            <asp:Button runat="server" ID="submit" OnClick="submit_Click" type="submit" Text="Subscribe" />
        </div>
        <div runat="server" id="subscriptionComlete">
            <span>Subscription is comleted</span>
        </div>
        <div>
            <span>Hello World!</span>
        </div>
        <div>
            <span>Success count: </span><span><%= mCount%></span>
        </div>
        <div>
            <span>Total count: </span><span><%= mTotalCount%></span>
        </div>
        <div>
            <span>Total downloads: </span><span runat="server" id="totalDownloadsSpan"></span>
        </div>
    </form>
</body>
</html>
