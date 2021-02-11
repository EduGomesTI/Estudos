package application;

import java.util.Scanner;

import entities.Triangle;

public class Program {
    public static void main(String[] args) {

        Triangle x, y;

        x = new Triangle();
        y = new Triangle();

        Scanner sc = new Scanner(System.in);
        System.out.println("Triângulo X");
        x.a = sc.nextDouble();
        x.b = sc.nextDouble();
        x.c = sc.nextDouble();

        System.out.println("Triângulo Y");
        y.a = sc.nextDouble();
        y.b = sc.nextDouble();
        y.c = sc.nextDouble();

        double areaX = x.area();

        double areaY = y.area();

        System.out.printf("Triangle X area: %.4f%n", areaX);

        System.out.printf("Triangle X area: %.4f%n", areaY);

        sc.close();
    }
}
