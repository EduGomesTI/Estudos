package entities;

public class Product {

    private String name;
    private double price;
    private int quantity;

    public Product(String name, double price, int quantity) {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    /**
     * @return String return the name
     */
    public String getName() {
        return name;
    }

    /**
     * @param name the name to set
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * @return double return the price
     */
    public double getPrice() {
        return price;
    }

    /**
     * @param price the price to set
     */
    public void setPrice(double price) {
        this.price = price;
    }

    /**
     * @return int return the quantity
     */
    public int getQuantity() {
        return quantity;
    }

    public double totalValueStock() {
        return price * quantity;
    }

    public void addProducts(int qtde) {
        quantity += qtde;
    }

    public void removeProducts(int qtde) {
        quantity -= qtde;
    }

    public String toString() {

        StringBuilder sb = new StringBuilder();
        sb.append("Produc data: ");
        sb.append(name);
        sb.append(", $ ");
        sb.append(String.format("%.2f", price));
        sb.append(", ");
        sb.append("units ");
        sb.append(quantity);
        sb.append(", Total: $ ");
        sb.append(String.format("%.2f", totalValueStock()));

        return sb.toString();
    }

}
