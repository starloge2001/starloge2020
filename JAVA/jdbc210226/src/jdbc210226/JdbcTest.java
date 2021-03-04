package jdbc210226;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.mysql.cj.protocol.Resultset;

public class JdbcTest {
	static Connection con;
	static Statement state;
	static final String USER_ID = "root";
	static final String USER_PW = "1126";
	static final String DBNAME = "test20210224";
	
	static String jdbcDriver = "com.mysql.cj.jdbc.Driver";
	static String dbUrl = "jdbc:mysql://localhost/" + DBNAME + "?autoReconnect=true&serverTimezone=UTC";
	
	public static void main(String[] args) {
		connectDB();
//		insertDB();
		showDB();
		closeDB();
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
	public static void insertDB() {
//		String query = String.format("insert into t_user values"+"(100, '홍길동',100,'hong@naver.com','010-1234-1234')");
		String name = "전우치";
		int age = 200;
		String email = "jon@kakao.com";
		String tel = "010-1111-1234";
		String query2 =  String.format("insert into t_user(user_nm,user_age,email,user_phone) values('%s','%d','%s','%s')",name,age,email,tel);
		
		try {
			state.executeUpdate(query2);
		} catch (SQLException e) {
			e.printStackTrace();
		}
			
	}
	public static void showDB() {
		String query = "select*from t_user";
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
	
}
