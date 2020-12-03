package ex1;

import java.util.Scanner;
public class ex5_2 {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("국어 점수를 입력하시오 :");
		int k = sc.nextInt();
		System.out.println("영어 점수를 입력하시오 :");
		int e = sc.nextInt();
		System.out.println("수학 점수를 입력하시오 :");
		int m = sc.nextInt();
		System.out.println("과학 점수를 입력하시오 :");
		int s = sc.nextInt();
		
		int a;
		double p;
		a = k+e+m+s;
		p = a / 4.0;
		
		System.out.println("총점 : " + a);
		System.out.println("평균 : " + p);

	}

}
