package application;

import java.util.Locale;
import java.util.Scanner;

import entities.Product;

public class ProductProgram {
    public static void main(String[] args) {

        Locale.setDefault(Locale.US);

        Scanner sc = new Scanner(System.in);

        Product product = new Product("TV", 900.00, 0);

        System.out.println("Enter pdoduct data:");
        System.out.print("Name: ");
        product.setName(sc.nextLine());
        System.out.print("Price: ");
        product.setPrice(sc.nextDouble());

        System.out.println(product);

        product.addProducts(5);

        System.out.println(product);

        product.removeProducts(3);

        System.out.println(product);

        sc.close();

    }

}
