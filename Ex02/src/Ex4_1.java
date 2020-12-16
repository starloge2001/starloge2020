import java.util.Scanner;

public class Ex4_1 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.println("--------------------------------");
		System.out.println(" 입력받은수의 합을 구하는 프로그램 v1.0");
		System.out.println("--------------------------------");
		int sum = 0;
		while(true) {
			System.out.print("1. 첫번째 숫자를 입력하세요 => ");
			int a = s.nextInt();
			System.out.print("2. 두번째 숫자를 입력하세요 => ");
			int b = s.nextInt();
		
			if (a>b) {
				for(int i = b;i<=a; i++) {
					sum = sum + i;
				}
			}
			else if (a<b) {
				for(int i =a; i<=b; i++) {
					sum = sum + i;
				}
			}
			else if (a==b) {
				System.out.println("같은 수를 입력하셧습니다. 다시 입력하십시오.");
				continue;
			}
			
			if(a<b) {
				System.out.printf("%d ~ %d까지의 합 : %d",a,b,sum);
			}
			else {
				System.out.printf("%d ~ %d까지의 합 : %d",b,a,sum);
			}
			break;
		}
		s.close();
	}

}
