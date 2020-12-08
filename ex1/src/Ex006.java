import java.util.Scanner;

public class Ex006 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("숫자를 입력 하세요 : ");
		int num1 = sc.nextInt();
		num1 = num1 / 2;
		if (num1 == 0) {
			System.out.println("입력한 숫자는 짝수 입니다.");
		}
		else {
			System.out.println("입력한 숫자는 홀수 입니다.");
		}
		sc.close();
	}

}
