<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Jusolink.Example._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>주소링크 SDK ASP.NET Example</title>
    <link href="Example.css" rel="stylesheet" type="text/css" />
</head>
	<body>

		<div id="content">

			<p class="heading1">주소검색 API SDK ASP.NET Example.</p>
			
			<br/>

			<fieldset class="fieldset1">
				<legend>주소링크 기본 API</legend>

				<fieldset class="fieldset2">
					<legend>회원사 정보</legend>
					<ul>
						<li><a href="Example/getUnitCost.aspx">getUnitCost</a> - 주소검색 단가 확인</li>
						<li><a href="Example/getBalance.aspx">getBalance</a> - 잔여포인트 확인</li>
					</ul>
				</fieldset>

			</fieldset>
			
			<br />
			
			<fieldset class="fieldset1">
				<legend>주소검색 관련</legend>
				
				<fieldset class="fieldset2">
					<legend>주소검색 예제</legend>
					<ul>
						<li><a href="Example/search.aspx">search</a> - 주소검색 </li>
					</ul>
				</fieldset>
			</fieldset>
		 </div>
	</body>
</html>
