package jdbc210304.dao;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

import jdbc210304.AddrbookMain;
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
	
	
	public Addrbook addrDB() {
		return new Addrbook(AddrbookMain.rd.getName(), AddrbookMain.rd.getAge(), AddrbookMain.rd.getEmail(), AddrbookMain.rd.getTel());
	}
	
	
	public void insertDB(Addrbook ad,String st) {
		String query2 =  String.format("insert into "+st+"(user_nm,user_age,email,user_phone) values('%s','%d','%s','%s')",ad.name,ad.age,ad.email,ad.tel);
		
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
	public void delData(Scanner s,String st) {
		System.out.print("삭제할 데이터 이름: ");
		String dd = s.next();
		String query = "DELETE FROM "+st+" WHERE user_nm = "+"'"+dd+"'";
		try {
			state.executeLargeUpdate(query);
		} catch (SQLException e) {
			//e.printStackTrace();
			System.out.println("삭제할 데이터가 없습니다.");
		}
		
	}
	public void upDatename(Scanner s,String st){
		System.out.print("수정하려는 이름을 입력해주세요 : ");
		String a = s.next();
		System.out.print("이름 수정값을 입력해주세요 : ");
		String b = s.next();
		String query = "UPDATE "+st+" SET user_nm = "+"'"+b+"'"+" where user_nm = '"+a+"'";
		try {
			state.executeLargeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	public void upDateage(Scanner s,String st){
		System.out.print("수정하려는 나이를 입력해주세요 : ");
		int a = s.nextInt();
		System.out.print("나이 수정값을 입력해주세요 : ");
		int b = s.nextInt();
		String query = "UPDATE "+st+" SET user_age = "+"'"+b+"'"+" where user_age = '"+a+"'";
		try {
			state.executeLargeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public void upDatetel(Scanner s,String st){
		System.out.print("수정하려는 전화번호를 입력해주세요 : ");
		String a = s.next();
		System.out.print("전화번호 수정값을 입력해주세요 : ");
		String b = s.next();
		String query = "UPDATE "+st+" SET user_phone = "+"'"+b+"'"+" where user_phone = '"+a+"'";
		try {
			state.executeLargeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public void upDateemail(Scanner s,String st){
		System.out.print("수정하려는 이메일을 입력해주세요 : ");
		String a = s.next();
		System.out.print("이메일 수정값을 입력해주세요 : ");
		String b = s.next();
		String query = "UPDATE "+st+" SET email = "+"'"+b+"'"+" where email = '"+a+"'";
		try {
			state.executeLargeUpdate(query);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
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
