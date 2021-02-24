package com.fiap.produto;

import com.fiap.produto.domain.Product;
import com.fiap.produto.service.CatalogService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class ProdutoApplication implements CommandLineRunner {

	@Autowired
	private CatalogService catalogService;

	public static void main(String[] args) {
		SpringApplication.run(ProdutoApplication.class, args);
	}

	@Override
	public void run(String... args) throws Exception {
		line();
		System.out.println("ProductApplication.run");
		System.out.println("Criar  Produto");
		final Product add = catalogService.add(1L,"produto 1", "Descrição 1");
		System.out.println(add);
		line();
	}

	private void line() {
		System.out.println();
		System.out.println("=====================================");
		System.out.println();
	}
}
