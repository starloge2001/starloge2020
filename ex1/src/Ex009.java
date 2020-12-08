import java.util.Scanner;

public class Ex009 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("년도를 입력 하세요 : ");
		int y = sc.nextInt();
		int a = y % 4;
		int b = y % 100;
		int c = y % 400;
		if ((a == 0 && b > 0)|| c == 0) {
			System.out.println(y + "년은 윤년입니다.");
		}
		else {
			System.out.println(y + "년은 윤년이 아닙니다.");
		}
		sc.close();
	}

}
