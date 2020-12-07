package ex001;

import java.util.Scanner;

public class ex008 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("첫번째 숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		System.out.println("두번째 숫자를 입력 하세요 : ");
		int num2 = sc.nextInt();
		System.out.println("연산자를 입력 하세요 : ");
		String a =sc.next();
		if (a.equals("+")) {
			System.out.println(num1 + " + " + num2 + " = " + (num1 + num2));
		}
		else if (a.equals("-")) {
			System.out.println(num1 + " - " + num2 + " = " + (num1 - num2));
		}
		else if (a.equals("*")) {
			System.out.println(num1 + " * " + num2 + " = " + (num1 * num2));
		}
		else {System.out.println(num1 + " / " + num2 + " = " + (num1 / num2));
	
		}
	}	
}
