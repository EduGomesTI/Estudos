package com.fiap.produto.service;

import com.fiap.produto.domain.Category;
import com.fiap.produto.domain.Product;
import org.springframework.stereotype.Service;

@Service
public class CatalogService {
    public Product add(final Long id, final String name, final String description) {
        return new Product(id, name, description, getDefaultCategory());



    }

    private Category getDefaultCategory() {
        return new Category(1L, "Padrão", "Padrão");
    }
}
