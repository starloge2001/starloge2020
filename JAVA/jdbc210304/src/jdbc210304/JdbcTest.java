package jdbc210304;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class JdbcTest {
	static final int CREATE_TABLE =1;
	static final int DEL_TABLE =2;
	static final int SELECT_TABLE =3;
	static final int ADD_DATA =4;
	static final int RANDOM_ADD_DATA =5;
	static final int VIEW_DATA =6;
	static final int UPDATE_DATA =7;
	static final int DEL_DATA =8;
	static final int MAIN_EXIT =9;
	
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "test20210224";
	
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	static String st = "t_user";
	
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		connectDB();
		while(true) {
			switch(menu(s)) {
			case CREATE_TABLE:
				createTable(s);
				break;
			case DEL_TABLE:
				delTable(s);
				break;				
			case SELECT_TABLE:
				selectTable(s);
				break;
			case ADD_DATA:
				break;
			case RANDOM_ADD_DATA:
				break;
			case VIEW_DATA:
				showDB(st);
				break;
			case UPDATE_DATA:
				break;
			case DEL_DATA:
				break;
			case MAIN_EXIT:
				s.close();
				closeDB();
				System.out.println("시스템 종료");
				System.exit(0);
				break;
			}
		
			
		}
		
	}
	
	public static void createTable(Scanner s) {
		System.out.print("생성할 테이블 : ");
		String ct = s.next();
		System.out.println("테이블 생성");
		String query = "create table "+ ct +"("+"id INT(10) NOT NULL AUTO_INCREMENT,"+"name VARCHAR(10) NOT NULL,"+ "age INT(3) NOT NULL,"+"tel VARCHAR(20) NOT NULL,"+"PRIMARY KEY(id))";
		try {
			state.executeUpdate(query);
		} catch (SQLException e) {
//			e.printStackTrace();
			System.out.println("같은 테이블 이름이 있습니다.");
		}
	}
	
	public static void delTable(Scanner s) {
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
	
	public static String selectTable(Scanner s) {
		System.out.print("선택할 테이블 : ");
		return st=s.next();
	}
	public static void showDB(String st) {
		String query = "select*from " + st;
		try {
			ResultSet rs = state.executeQuery(query);
			if(rs != null) {
				rs= state.getResultSet();
				int count = 0;
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
			e.printStackTrace();
		}
	}

	public static int menu(Scanner s) {
		
		System.out.println("-----------------------------");
		System.out.println("      MySQL DB 관리 v1.0");
		System.out.println("-----------------------------");
		System.out.println("1. 테이블 생성");
		System.out.println("2. 테이블 삭제");
		System.out.println("3. 테이블 선택");
		System.out.println("4. 데이터 추가");
		System.out.println("5. 랜덤 데이터 추가");
		System.out.println("6. 데이터 보기");
		System.out.println("7. 데이터 수정");
		System.out.println("8. 데이터 삭제");
		System.out.println("9. 프로그램 종료");		
		System.out.println("-----------------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}
	public static void connectDB() {
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
	
	public static void closeDB(){
		try {
			con.close();
			System.out.println("DB 접속 해제");
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
}

