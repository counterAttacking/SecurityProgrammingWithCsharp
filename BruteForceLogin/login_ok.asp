<%
    If request("userid")="" Then
%>
<script>
    location.href="./login.html";
</script>
<%
    End if
    If request("userid") <> "morning" or requesst("userpasswd") <> "1234" Then
%>
<script>
    location.href="./login_fail.asp";
</script>
<%
    End id
    loginId=request("userid")
    loginPasswd=request("userpasswd")
%>
<html>
    <head>
        <meta charset="utf-8" />
        <title>인증화면</title>
    </head>
    <body>
        입력한 ID : <%=loginId %><br />
        입력한 Password : <%=loginPasswd %>
    </body>
</html>