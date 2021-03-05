package jdbc210304.model;

public class Addrbook {
	public String name;
	public int age;
	public String tel;
	public String email;
	public Addrbook(String name, int age, String email, String tel) {
		super();
		this.name = name;
		this.age = age;
		this.tel = tel;
		this.email = email;
	}
	public String getName() {
		return name;
	}
	public void setName(String name) {
		this.name = name;
	}
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		this.age = age;
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
