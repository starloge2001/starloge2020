package jdbc210304;

import java.util.Scanner;

import jdbc210304.dao.MySQL_Handler;
import jdbc210304.util.Menu;

public class AddrbookMain {

	
	
	
	public static void main(String[] args) {
		MySQL_Handler db = new MySQL_Handler();
		Menu menu=new Menu();
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
				break;
			case Menu.VIEW_DATA:
				db.showDB(MySQL_Handler.st);
				break;
			case Menu.UPDATE_DATA:
				break;
			case Menu.DEL_DATA:
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

