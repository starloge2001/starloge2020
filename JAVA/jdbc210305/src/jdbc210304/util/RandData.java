package jdbc210304.util;

import java.util.Random;

public class RandData {
	static String name[] ={"홍길동", "김길동", "이길동", "박길동", "최길동"};
	static int age[] = {10,15,20,25,30};
	static String[] tel = {"010-1111-1111",
        "010-2222-2222", "010-2222-3333",
        "010-2222-4444", "010-2222-5555"};
	static String[] email = {"hong@naver.com",
        "kim@naver.com", "lee@naver.com",
        "park@naver.com", "choi@naver.com"};
	Random r = new Random();
	public void RanData(Random r) {
		this.r=r;
	}
	
	public String getName() {
		return name[r.nextInt(5)];
	}
	public int getAge() {
		return age[r.nextInt(5)];
	}
	public String getTel() {
		return tel[r.nextInt(5)];
	}
	public String getEmail() {
		return email[r.nextInt(5)];
	}

	
}
