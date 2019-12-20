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
    <title>ID/Passwd 확인</title>
</head>
<body>
    로그인 실패 하였습니다. 다시 로그인 하세요.
    <form id='login_form' method="post" action="./login_ok.asp">
        ID : <input id="userid" name='userid' type="text" /><br />
        PassWord : <input id="userpassswd" name='userpasswd' type="password" /><br />
        <input type="submit" value="로그인" />
    </form>
</body>
</html>