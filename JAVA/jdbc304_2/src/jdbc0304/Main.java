package jdbc0304;

import java.util.Scanner;

import jdbc0304.dao.JdbcController;
import jdbc0304.dao.JdbcForMySQL;
import jdbc0304.util.Menu;

public class Main {

	public static final String CREATE_TABLE = "1";
	public static final String DEL_TABLE = "2";
	public static final String USE_TABLE = "3";
	public static final String SHOW_TABLES = "4";
	public static final String SHOW_TABLE_COLS = "5";
	public static final String INSERT_DATA = "6";
	public static final String VIEW_DATA = "7";
	public static final String UPDATE_DATA = "8";
	public static final String DEL_DATA = "9";
	public static final String MAIN_EXIT = "10";

	private static JdbcForMySQL db;
	private static JdbcController dbCtrl;
	public static Scanner s = new Scanner(System.in);



	public static void main(String[] args) {
		
		System.out.println("MySQL의 ID와 PW를 입력해주세요");
		System.out.println("예 (ID : root, PW : 1126) ");
		String id, pw;
		while(true) {
			System.out.print("ID : ");
			id = s.next();
			System.out.print("PW : ");
			pw = s.next();
			db = JdbcForMySQL.connection(id, pw);
			if(db == null) {
				System.out.println("데이터베이스에 연결이 안돼요 ㅠ ㅠ...");
			}
			else
				break;
		}
		dbCtrl = new JdbcController(db);

		while(!dbCtrl.tryUseDatabase()) {
			System.out.println("데이터베이스명을 확인해주세요..");
			System.out.println("다시 입력하세요\n\n\n\n\n\n\n\n");
		}
		System.out.println("\n\n\n\n\n\n\n\n");
		while(!dbCtrl.tryUseTable()) {
			System.out.println("테이블명이 잘못됬습니다. 또는 해당 테이블에는 Column이 존재하지 않습니다");
			System.out.println("다시 입력하세요\n\n\n\n\n\n\n\n");
		}

		Menu.menuRun(db, dbCtrl, s);

	}
	
}
