package webapp0325.dao;

import java.util.ArrayList;

import webapp0325.dto.Product;

public class ProductRepo {
	private ArrayList<Product> listOfProducts = new ArrayList<Product>();
	
	public ProductRepo() {
		Product iphone = new Product("P1111", "iPhone12", 1000000);
		iphone.setDescription("6인치, 1334x750 Renine HD Display, 8-megepixel Camera");
		iphone.setCategory("스마트폰");
		iphone.setMenufacturer("애플");
		iphone.setUnitInStock(1000);
		iphone.setCondition("2020년 상품");
		listOfProducts.add(iphone);
		
		Product notebook = new Product("P1112", "LG 그램2021", 2500000);
		notebook.setDescription("15인치, 2000x1850 OLED HD Display, 인텔i7 11세대, 메모리 DDR4");
		notebook.setCategory("노트북");
		notebook.setMenufacturer("ㅣㅎ");
		notebook.setUnitInStock(1000);
		notebook.setCondition("2021년 상품");
		listOfProducts.add(notebook);
		
		Product tablet = new Product("P3111", "삼성 갤럭시탭S7", 4000000);
		tablet.setDescription("10인치, 2000x1850 OLED HD Display, 메모리 128G");
		tablet.setCategory("테블릿");
		tablet.setMenufacturer("삼성");
		tablet.setUnitInStock(1000);
		tablet.setCondition("2020년 상품");
		listOfProducts.add(tablet);
	}
	
	public ArrayList<Product> getAllProduct(){
		return listOfProducts;
	}
	
	public Product getProductById(String productId) {
		Product productById = null;
		for (int i=0; i<listOfProducts.size();i++) {
			Product product = listOfProducts.get(i);
			if(product !=null && product.getProductId() != null && product.getProductId().equals(productId)) {
				productById = product;
				break;
			}
		}
		return productById;
	}
}
