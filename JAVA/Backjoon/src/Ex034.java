import java.util.Scanner;

public class Ex034 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int k = s.nextInt();
		String[] a = new String[k];
		int sum=0;
		int con=0;
		for (int i = 0; i < k; i++) {
			a[i]=s.next();
			int[] count = new int[a[i].length()];
			for (int j = 0; j < count.length; j++) {
				if(a[j].equals("o")) {
					con++;
				}
				else {
					con=0;
				}
				sum=sum+con;
				System.out.println(sum);
			}
			System.out.println(sum);
		}				
		s.close();
	}

}
