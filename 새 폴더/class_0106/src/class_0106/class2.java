package class_0106;

public class class2 {

	public static void main(String[] args) {
		Student2 s = new Student2();
		s.setName("홍길동");
		s.setEmail("hong@naver.com");
		s.setTel("010-1234-1234");
		s.setName("김길동");
		
		System.out.println("이름 : " + s.getName());
		System.out.println("이메일 : " + s.getEmail());
		System.out.println("전화 : " + s.getTel());
		System.out.println("과정 : " + Student.category);
		
		Student2 ss = new Student2();
		ss.setName("최길동");
		ss.setEmail("choi@naver.com");
		ss.setTel("010-1234-5678");
		System.out.println("이름 : " + ss.getName());
		System.out.println("이메일 : " + ss.getEmail());
		System.out.println("전화 : " + ss.getTel());
		System.out.println("과정 : " + Student.category);
	}

}
/*
// 주소록 클래스 정의  class 는 사용하기위해 위에서처럼 객체생성을 해줘야한다 
class Student2 {
	// 클래스 변수  static가 붙으면 클래스 변수
	static String category = "통합응용SW과정";
	
	// public : 외부 클래스에서 접근 가능
	// private : 외부 클래스에 접근 불가
	// 인스턴스 변수
	private String name;
	private String tel;
	private String email;
	
	// 인스턴스 메쏘드
	// setter 
	public void setName(String name) {
		this.name = name;
	}
	
	// getter 정보를 가지고오는
	public String getName() {
		return name;
	}

	public String getTel() {
		return tel;
	}

	public void setTel(String tel) {
		this.tel = tel;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}
	
} */