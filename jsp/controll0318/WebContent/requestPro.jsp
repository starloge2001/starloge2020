<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%
request.setCharacterEncoding("UTF-8");
	
int num = Integer.parseInt(request.getParameter("num"));
String name = request.getParameter("name");
int grade = Integer.parseInt(request.getParameter("grade"));
String subject = request.getParameter("subject");
String gn = null;
String sn = null;

switch(grade){
case 1:
	gn = "1학년";
	break;
case 2:
	gn = "2학년";
	break;
case 3:
	gn = "3학년";
	break;
case 4:
	gn = "4학년";
	break;
}

switch(subject){
case "JAVA":
	sn = "JAVA";
	break;
case "JSP":
	sn = "JSP";
	break;
case "JAVASCRIPT":
	sn = "자바스크립트";
	break;
}

out.println("<b>" + name + "</b>의 학번은"+num+"이고 학년은 "+gn+"이고 과목은 "+sn+"이다"); 
%>


<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>

</body>
</html>