class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
}