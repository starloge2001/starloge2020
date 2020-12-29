import java.util.Random;

public class Ex016 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Random rand = new Random();
		System.out.println("---------------------");
		System.out.println("간단한 로또 프로그램 v1.0");
		System.out.println("---------------------");
		int[] n = new int[6];
		for (int i = 0; i < 6;i++) {
			n[i] = rand.nextInt(45);
			for (int j=0;j<i;j++) {
				if (n[j]==n[i]) {
					i--;
				}
			}
		}
		for (int i = 0; i < n.length; i++) {
			System.out.print(n[i] + "  ");
		}
	}

}
