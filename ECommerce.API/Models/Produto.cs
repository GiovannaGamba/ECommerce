using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.API.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    [Required]
    [StringLength(80)]
    public string? Nome { get; set; }
    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    public float Estoque { get; set; }

    private Produto()
    {

    }

    public Produto(int produtoId, string? nome, string? descricao, decimal preco, float estoque)
    {
        ProdutoId=produtoId;
        Nome=nome;
        Descricao=descricao;
        Preco=preco;
        Estoque=estoque;

        ValidarPreco();
    }

    public void ValidarPreco()
    {
        if (Preco < 0)
        {
            throw new Exception("Preço não pode ser menor que 0,00.");
        }
    }
}
