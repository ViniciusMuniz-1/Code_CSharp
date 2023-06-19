using System;

using CadastroProduto;

class Program {
  public static void Main() {
    Console.WriteLine("Bem-vindo(a) ao IF Shop!");

    int op = 100;
    while (op != 0) {
    try{
      op = MenuAdmin();
        switch(op) {
        case 1 : CategoriaListar(); break;
        case 2 : CategoriaInserir(); break;
        case 3 : CategoriaAtualizar(); break;
        case 4 : CategoriaExcluir(); break;
        case 5 : ProdutoListar(); break;
        case 6 : ProdutoInserir(); break;
        case 7 : ProdutoAtualizar(); break;
        case 8 : ProdutoExcluir(); break;
            }
      }
    catch(Exception erro){
        Console.Write(erro.Message);
    }
    }
    Console.WriteLine("Bye!");
  }
  public static int MenuAdmin() {
    Console.WriteLine("Admin logado");
    Console.WriteLine("Cadastro de Produtos");
    Console.WriteLine("---------------------");
    Console.WriteLine("Espaço das categorias:");
    Console.WriteLine("| 1 - Listar Categorias    |");
    Console.WriteLine("| 2 - Inserir Categorias   |");
    Console.WriteLine("| 3 - Atualizar Categorias |");
    Console.WriteLine("| 4 - Excluir Categorias   |");
    Console.WriteLine("---------------------");
    Console.WriteLine("Espaço dos produtos:");
    Console.WriteLine("| 5 - Listar Produtos      |");
    Console.WriteLine("| 6 - Inserir Produtos     |");
    Console.WriteLine("| 7 - Atualizar Produtos   |");
    Console.WriteLine("| 8 - Excluir Produtos     |");
    Console.WriteLine("---------------------");
    Console.WriteLine("0 - Fim\n");
    Console.Write("Opção: ");
    
    return int.Parse(Console.ReadLine());
  }

  public static void CategoriaListar() {
    Console.WriteLine("Listagem de categorias");
    foreach (Categoria c in NCategoria.Listar())
      Console.WriteLine(c);
    Console.WriteLine();
  }

  public static void CategoriaInserir() {
    Console.WriteLine("Inserção de categoria");
    Console.Write("Informe a descrição: ");
    string s = Console.ReadLine();
    Categoria c = new Categoria { Descricao = s };
    NCategoria.Inserir(c);
    Console.WriteLine("Categoria inserida com sucesso");
  }

  public static void CategoriaAtualizar() {
    Console.WriteLine("Atualização de categoria");
    Console.Write("Informe o ID: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Informe a descrição: ");
    string s = Console.ReadLine();

    Categoria c = new Categoria { Id = id, Descricao = s };
    NCategoria.Atualizar(c);
    Console.WriteLine("Categoria inserida com sucesso");
  }

  public static void CategoriaExcluir() {
    Console.WriteLine("Atualização de categoria");
    Console.Write("Informe o ID: ");
    int id = int.Parse(Console.ReadLine());

    Categoria c = new Categoria { Id = id };
    NCategoria.Excluir(c);
  }

  public static void ProdutoListar() {
    Console.WriteLine("Listagem de Produtos");
    foreach (Produto p in NProduto.Listar())
      Console.WriteLine(p);
    Console.WriteLine();
  }
  public static void ProdutoInserir() {
    Console.WriteLine("Inserção de Produto");

    Console.Write("Informe a descrição: ");
    string descricao = Console.ReadLine();

    Console.Write("Informe o preço: ");
    double preco = double.Parse(Console.ReadLine());

    Console.Write("Informe a quantidade de itens em estoque: ");
    int estoque = int.Parse(Console.ReadLine());
    
    Console.Write("Informe a categoria do item:");
    int idCategoria = int.Parse(Console.ReadLine());
    
    Produto p = new Produto { Descricao = descricao, Preco = preco, Estoque = estoque, IdCategoria = idCategoria };
    NProduto.Inserir(p);

    Console.WriteLine("Produto inserido com sucesso");
  }
  public static void ProdutoAtualizar() {
    Console.WriteLine("Atualização de Produto");

    Console.Write("Informe o ID do produto: ");
    int id = int.Parse(Console.ReadLine());

    Console.Write("Informe a descrição: ");
    string descricao = Console.ReadLine();
    
    Console.Write("Informe o preço: ");
    double preco = double.Parse(Console.ReadLine());

    Console.Write("Informe a quantidade de itens em estoque: ");
    int estoque = int.Parse(Console.ReadLine());

    Console.Write("Informe a nova categoria do item:");
    int idCategoria = int.Parse(Console.ReadLine());
    
    Produto p = new Produto { Id = id, Descricao = descricao, Preco = preco, Estoque = estoque, IdCategoria = idCategoria };
    NProduto.Atualizar(p);

    Console.WriteLine("Produto atualizado com sucesso");
  }
  public static void ProdutoExcluir() {
    Console.WriteLine("Remoção de Produto");

    Console.Write("Informe o ID do produto: ");
    int id = int.Parse(Console.ReadLine());

    Produto p = new Produto { Id = id };
    NProduto.Excluir(p);

    Console.WriteLine("Produto excluido com sucesso");
  }
}