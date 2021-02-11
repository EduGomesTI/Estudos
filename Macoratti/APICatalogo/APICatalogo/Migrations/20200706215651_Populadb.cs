using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Categorias(Nome, ImageUrl) Values('Bebidas', 'http://leximusinagem.com.br/imagens/1.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImageUrl) Values('Lanches', 'http://leximusinagem.com.br/Imagens/2.jpg')");
            mb.Sql("Insert Into Categorias(Nome, ImageUrl) Values('Sobremesas', 'http://leximusinagem.com.br/Imagens/3.jpg')");

            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, IdCategoria) Values('Coca-Cola Diet', 'Refrigerante de Cola 350 ml', 5.45, 'http://leximusinagem.com.br/imagens/coca.jpg', 50, now(), " +
                "(Select IdCategoria from Categorias where Nome='Bebidas'))");
            
            
            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, IdCategoria) " +
                "Values('Lanche de Atum', 'Lanche de Atum com Maionese', 8.50, 'http://leximusinagem.com.br/Imagens/atum.jpg', 10, now()," +
                "(Select IdCategoria from Categorias where Nome='Lanches'))");


            mb.Sql("Insert into Produtos(Nome, Descricao, Preco, ImageUrl, Estoque, DataCadastro, IdCategoria) " +
                "Values('Pudim 100 g', 'Oudim de leite condensado 100g', 6.75, 'http://leximusinagem.com.br/Imagens/pudim.jpg', 20, now()," +
                "(Select IdCategoria from Categorias where Nome='Sobremesas'))");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}
