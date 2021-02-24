package com.fiap.produto.domain;

import java.util.Objects;

public class Product {

    private Long Id;
    private String name;
    private String description;
    private Category category;


    public Product() {
    }

    public Product(Long id, String name, String description, Category category) {
        Id = id;
        this.name = name;
        this.description = description;
        this.category = category;
    }

    public Long getId() {
        return Id;
    }

    public void setId(Long id) {
        Id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Category getCategory() {
        return category;
    }

    public void setCategory(Category category) {
        this.category = category;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Product product = (Product) o;
        return Objects.equals(Id, product.Id);
    }

    @Override
    public int hashCode() {
        return Objects.hash(Id);
    }

    @Override
    public String toString() {
        return "Product{" +
                "Id=" + Id +
                ", name='" + name + '\'' +
                ", description='" + description + '\'' +
                ", category=" + category +
                '}';
    }
}
