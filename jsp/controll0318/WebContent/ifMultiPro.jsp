<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
	request.setCharacterEncoding("UTF-8");
%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		String name = request.getParameter("name");
		String local = request.getParameter("local");
		String tel = request.getParameter("tel");
		String localNum="";

		switch(local){
		case "서울":
			localNum = "02";
			break;
		case "대구":
			localNum = "053";
			break;
		case "부산":
			localNum = "051";
			break;
		}
		out.println("<b>" + name + "</b>님의 전화번호는 " + localNum + "-" + tel + "입니다.");
	%>
</body>
</html>