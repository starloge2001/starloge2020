import java.util.Scanner;

public class Ex006 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		String a;
		num1 = num1 / 2;
		a = (num1 == 0) ? "입력한 숫자는 홀수 입니다." : "입력한 숫자는 짝수 입니다.";
		System.out.println(a);
		sc.close();
	}

}
