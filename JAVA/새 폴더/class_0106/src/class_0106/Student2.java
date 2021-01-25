package class_0106;

public class Student2 {
	
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
}
