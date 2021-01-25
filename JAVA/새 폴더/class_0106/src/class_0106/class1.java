package class_0106;

public class class1 {

	public static void main(String[] args) {
		Student s = new Student();
		s.name = "홍길동";
		s.email = "hong@naver.com";
		s.tel = "010-1234-1234";
		s.name = "김길동";
		
		System.out.println("이름 : " + s.name);
		System.out.println("이메일 : " + s.email);
		System.out.println("전화 : " + s.tel);
		System.out.println("과정 : " + Student.category);
		
		Student ss = new Student();
		ss.name = "최길동";
		ss.email = "choi@naver.com";
		ss.tel = "010-1234-5678";
		System.out.println("이름 : " + ss.name);
		System.out.println("이메일 : " + ss.email);
		System.out.println("전화 : " + ss.tel);
		System.out.println("과정 : " + Student.category);
	}

}

// 주소록 클래스 정의  class 는 사용하기위해 객체생성을 해줘야한다 
class Student {
	// 클래스 변수  static가 붙으면 클래스 변수
	static String category = "통합응용SW과정";
	// 인스턴스 변수
	String name;
	String tel;
	String email;
}