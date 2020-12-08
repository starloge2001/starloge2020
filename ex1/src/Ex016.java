import java.util.Random;

public class Ex016 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Random rand = new Random();
		System.out.println("---------------------");
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println("---------------------");
		for (int n = 0; n < 6;n++) {
			int num = rand.nextInt(45);
			System.out.print(num + "  ");
		}
	}

}
