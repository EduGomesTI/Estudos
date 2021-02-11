import java.util.ArrayList;
import java.util.List;
import java.util.function.Consumer;
import java.util.function.Function;
import java.util.function.Predicate;
import java.util.stream.Collectors;

import entities.Product;

public class App {
    public static void main(String[] args) throws Exception {

        List<Product> list = new ArrayList<>();

        list.add(new Product("TV", 900.00));
        list.add(new Product("Mouse", 50.00));
        list.add(new Product("Tablet", 350.50));
        list.add(new Product("HD Case", 80.90));

        list.sort((p1, p2) -> p1.getName().toUpperCase().compareTo(p2.getName().toUpperCase()));

        // * Formas de usar Interfaces funcionais Predicate.
        // Predicate<Product> pred = p -> p.getPrice() <= 100.0;
        // list.removeIf(p -> p.getPrice() >= 100);
        // list.removeIf(Product::staticProductPredicate);
        // list.removeIf(Product::nonStaticProductPredicate);
        // list.removeIf(pred);

        // * Interface Funcional Consumer
        // list.forEach(new PriceUpdate());
        // list.forEach(Product::staticPriceUpdate);
        // list.forEach(Product::nonStaticPriceUpdate);
        // Consumer<Product> cons = p -> {
        // p.setPrice(p.getPrice() * 1.1);
        // };
        // list.forEach(cons);
        // list.forEach(p -> p.setPrice(p.getPrice() * 1.1));

        // * Interface Funcional Function
        // List<String> names = list.stream().map(new
        // UpperCaseName()).collect(Collectors.toList());
        // List<String> names =
        // list.stream().map(Product::staticUpperCaseName).collect(Collectors.toList());
        // List<String> names =
        // list.stream().map(Product::nonStaticUpperCaseName).collect(Collectors.toList());
        // Function<Product, String> func = p -> p.getName().toUpperCase();
        // List<String> names = list.stream().map(func).collect(Collectors.toList());
        // List<String> names = list.stream().map(p ->
        // p.getName().toUpperCase()).collect(Collectors.toList());

        // list.forEach(System.out::println);
        // System.out.println();
        // names.forEach(System.out::println);

        // * Aula 224
        // ProductService ps = new ProductService();
        // double sum = ps.filteredSum(list, p -> p.getPrice() < 100.0);
        // System.out.println("Sum = " + String.format("%.2f", sum));

        

    }
}
