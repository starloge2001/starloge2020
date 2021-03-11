package jdbc210304.util;

import java.util.Scanner;

public class Menu {
	public static final int CREATE_TABLE =1;
	public static final int DEL_TABLE =2;
	public static final int SELECT_TABLE =3;
	public static final int ADD_DATA =4;
	public static final int RANDOM_ADD_DATA =5;
	public static final int VIEW_DATA =6;
	public static final int UPDATE_DATA =7;
	public static final int DEL_DATA =8;
	public static final int MAIN_EXIT =9;
	public static String st = "t_user";
	public static final int NAME = 1;
	public static final int AGE = 2;
	public static final int EMAIL = 3;
	public static final int TEL = 4;
	public int menu(Scanner s) {
		
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
	public int menu2(Scanner s) {
		System.out.println("-----------------------------");
		System.out.println("      MySQL DB 관리 v1.0");
		System.out.println("-----------------------------");
		System.out.println("1. 이름 수정");
		System.out.println("2. 나이 수정");
		System.out.println("3. 이메일 수정");
		System.out.println("4. 전화번호 수정");
		System.out.println("-----------------------------");
		System.out.print("메뉴 선택 : ");
		return s.nextInt();
	}
}
