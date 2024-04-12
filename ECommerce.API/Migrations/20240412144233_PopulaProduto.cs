using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into produtos (ProdutoId,Nome,Descricao,Preco,Estoque)" +
                "Values(6,'Camiseta Feminina','Camiseta Feminina Rosa',30.90,47)");

            mb.Sql("Insert into produtos (ProdutoId,Nome,Descricao,Preco,Estoque)" +
                "Values(2,'Camiseta Masculina','Camiseta Masculina Preta',30.90,24)");

            mb.Sql("Insert into produtos (ProdutoId,Nome,Descricao,Preco,Estoque)" +
                "Values(3,'Calça Feminina','Calça Feminina Jeans',129.99,32)");

            mb.Sql("Insert into produtos (ProdutoId,Nome,Descricao,Preco,Estoque)" +
                "Values(4,'Calça Masculina','Calça Masculina Jeans',139.99,18)");

            mb.Sql("Insert into produtos (ProdutoId,Nome,Descricao,Preco,Estoque)" +
                "Values(5,'Chápeu','Chápeu Unisex',20.50,87)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
