package jdbc210304.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import jdbc210304.model.Addrbook;

public class MySQL_Handler {
	Connection con;
	Statement state;
	final String USER_ID = "root";
	final String USER_PW = "1126";
	final String DBNAME = "test20210224";
	
	String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	public MySQL_Handler() {
		connectDB();
		
	}
	
	public void connectDB() {
		try {
			Class.forName(jdbcDriver);
			con = DriverManager.getConnection(dbUrl,USER_ID,USER_PW);
			if (con != null) {
				state = con.createStatement();
				System.out.println("DB 접속 성공");
			}
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	public void closeDB(){
		try {
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	public Addrbook addrDB(Scanner s) {
//		String query = String.format("insert into t_user values"+"(100, '홍길동',100,'hong@naver.com','010-1234-1234')");
		System.out.print("이름을 입력하세요 : ");
		String name = s.next();
		System.out.print("나이를 입력하세요 : ");
		int age = s.nextInt();
		System.out.print("email을 입력하세요 : ");
		String email = s.next();
		System.out.print("전화번호를 입력하세요 : ");
		String tel = s.next();

		return new Addrbook(name, age, email, tel);	
	
	}
	public void insertDB(Addrbook ad,String st) {
		String query2 =  String.format("insert into "+st+"(user_nm,user_age,email,user_phone) values('%s','%d','%s','%s')",ad.name,ad.age,ad.tel,ad.email);
		
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	public void createTable(Scanner s) {
		System.out.print("생성할 테이블 : ");
		String ct = s.next();
		System.out.println("테이블 생성");
		String query = "create table "+ ct +"("+"id INT(10) NOT NULL AUTO_INCREMENT,"+"name VARCHAR(10) NOT NULL,"+ "age INT(3) NOT NULL,"+"email VARCHAR(20) NOT NULL,"+"tel VARCHAR(20) NOT NULL,"+"PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
//			e.printStackTrace();
			System.out.println("같은 테이블 이름이 있습니다.");
		}
	}
	
	public void delTable(Scanner s) {
		System.out.print("삭제할 테이블 : ");
		String dt = s.next();
		System.out.println("테이블 삭제");
		String query = "drop table " +dt ;
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
			System.out.println("삭제할 테이블이 없습니다.");
//			e.printStackTrace();
		}
	}
	public static String st="t_user";
	public String selectTable(Scanner s) {
		System.out.print("선택할 테이블 : ");
		return st=s.next();
	}
	public void showDB(String st) {
		String query = "select*from " + st;
		try {
			ResultSet rs = state.executeQuery(query);
			if(rs != null) {
				rs= state.getResultSet();
				int count = 1;
				while (rs.next()) {
					System.out.print(count++ +"\t");
					System.out.print(rs.getString("user_nm")+"\t");
					System.out.print(rs.getString("user_age")+"\t");
					System.out.print(
							new StringBuilder()
							.append(rs.getString("email"))
							.append((rs.getString("email").length() < 15)? "\t\t" : "\t")
							);
					System.out.println(rs.getString(5)+"\t"); // 인덱스로 불러옴 "user_phone"
					
				}
			}
		} catch (SQLException e) {
//			e.printStackTrace();
			System.out.println("테이블이 없습니다.");
		}
	}


}
