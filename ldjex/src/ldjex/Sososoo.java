package ldjex;

import java.util.Scanner;

public class Sososoo {

	public static void main(String[] args) {
		System.out.println("첫번째 숫자를 입력하시오 : ");
		Scanner sc = new Scanner(System.in);
		int a = sc.nextInt();
		System.out.println("두번째 숫자를 입력하시오 : ");
		int b = sc.nextInt();
		int c;
		int d;
		int e;
		c = b / 100;
		e = b % 100;
		d = e / 10;
		e = e % 10;
		System.out.println(e * a);
		System.out.println(d * a);
		System.out.println(c * a);
		System.out.println(b * a);
		
	}

	

}
