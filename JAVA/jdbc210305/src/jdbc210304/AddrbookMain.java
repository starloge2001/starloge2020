package jdbc210304;

import java.util.Scanner;

import jdbc210304.dao.MySQL_Handler;
import jdbc210304.util.Menu;
import jdbc210304.util.RandData;

public class AddrbookMain {

	
	public static RandData rd = new RandData();
	
	public static void main(String[] args) {
		MySQL_Handler db = new MySQL_Handler();
		Menu menu=new Menu();
//		RandData rd = new RandData();
		Scanner s = new Scanner(System.in);
		
		while(true) {
			switch(menu.menu(s)) {
			case Menu.CREATE_TABLE:
				db.createTable(s);
				break;
			case Menu.DEL_TABLE:
				db.delTable(s);
				break;				
			case Menu.SELECT_TABLE:
				db.selectTable(s);
				break;
			case Menu.ADD_DATA:
//				db.insertDB(s,MySQL_Handler.st);
				db.insertDB(db.addrDB(s), MySQL_Handler.st);
				break;
			case Menu.RANDOM_ADD_DATA:
				db.insertDB(db.addrDB(), MySQL_Handler.st);
				break;
			case Menu.VIEW_DATA:
				db.showDB(MySQL_Handler.st);
				break;
			case Menu.UPDATE_DATA:
				switch(menu.menu2(s)) {
				case Menu.NAME:
					db.upDatename(s, MySQL_Handler.st);
					break;
				case Menu.AGE:
					db.upDateage(s, MySQL_Handler.st);
					break;
				case Menu.EMAIL:
					db.upDateemail(s, MySQL_Handler.st);
					break;
				case Menu.TEL:
					db.upDatetel(s, MySQL_Handler.st);
					break;
				}
				break;
			case Menu.DEL_DATA:
				db.delData(s, MySQL_Handler.st);
				break;
			case Menu.MAIN_EXIT:
				s.close();
				db.closeDB();
				System.out.println("시스템 종료");
				System.exit(0);
				break;
			}
		
			
		}
		
	}
	

	
}

