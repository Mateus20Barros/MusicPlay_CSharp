<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="120"/>
</div> <br>

### 📃 Sobre o Projeto

**MusicPlay e um sistema de Stream Musical, desenvolvido na linguagem ``CSharp`` onde o usuario pode realizar cadastro de ``Banda``, ``Album`` e ``Musica``.
Há tambem uma classe chamada ``Episodio`` que foi adicionada durante o desenvolvimento do projeto no curso, com foco no Stream de Filmes.** <br>

**A parte visual do programa e exibida via ``Terminal``, visto que o projeto e apenas um pequeno conceito de Orientação a Objeto da linguagem CSharp.**

<br>

### 🔥 Conceitos POO Aplicados ao Projeto

**``🏷️ Classes ``** <br>
**Introduzido os conceitos de ``Classes`` como definir e para que server.**
<br>

```csharp
public class Banda
{
  ...
}
```
<br>

**``🏷️ Modificadores de Acessos ``** <br>
**Explicado os casos usos dos modificadores de acessos de ``atributos`` e ``metodos`` das classes, tais como:** <br>

| **Modificadores** | **Descrição** |
| --- | --- |
| **internal** | ***Modificador de acesso padrao se nenhum modificador for especificado.*** |
| **public** | ***Permite que qualquer parte do programa acesse o tipo e os membros.*** |
| **private** | ***Permite que apenas codigo da mesma classe ou estruturas (structs) acesse.*** |
| **protected** | ***Permite que a mesma classe e classes derivadas dessa mesma classe acesse seu tipo e membros.*** |

```csharp
public class Banda
{
    private double ganhosDasBandas;
    protected int quantidadeBandas;
}
```
<br>

**``🏷️ Constructor ``** <br>
**Introduzido o metodo ``Constructor``, que e um tipo especial que será chamado automaticamente quando e criado uma instancia da classe.**
```CSharp
class Banda
{
    private string nomeBanda;
    private int qtdeBandas;

    public Banda(string nome, int quantidade)
    {
        nomeBanda = nome;
        qtdeBandas = quantidade;
    }
}
```
🔹 **Nome do construtor deve ser o mesmo nome da classe.** <br>
🔹 **Constructor pode ser ``public``, ``private`` ou ``protected``.** <br>
🔹 **Construtor não pode retornar nenhum valor, entao não pode contém nenhum tipo de retorno .** <br>
🔹 **Construtor pode ter varios construtores com diferentes parametros, mas só pode ter um construtor sem parametros.** <br>
🔹 **Se o construtor não e definido, o compilador ``CSharp`` internamente cria o construtor.** <br>
<br>

**``🏷️ Collection List<> ``** <br>
**Uma Collection de objetos fortemente tipada que armazena e acessa os seus valores 
por indice, e possue metodos que classifica, pesquisa e modifica a lista.** <br>

```csharp
public class Banda
{
    // Forma completa de instanciar uma List.
    public List<string> listaDeBandas = new List<string>();

    // Forma simples de instanciar uma List.
    public List<string> nomeDaBanda = new(); 
}
```
<br>

**``🏷️ Propriedades Get & Set ``** <br>
**Introduzido o uso das propriedades ``get`` e ``set`` nas definições dos atributos das classes.** <br>

```csharp
public class Banda
{
    private double ganhosDasBandas { get; set; }
    protected int quantidadeBandas { get; set; }
}
```
<br>

**``🏷️ Expressões Lambdas ``** <br>
**Introduzido os conceitos das expressões ou funções ``Lambdas`` com a flecha `=>`.** <br>
 ```csharp
public class Banda
{
    protected int quantidadeBandas => nomeDasBandas.Count();
}
```
<br>

**``🏷️ Metodo Foreach() ``** <br>
**Usado para percorrer uma ``List<>`` ao invês do ``for`` tradicional.** <br>
 ```csharp
public class Banda
{
    public List<string> nomeDasBandas = new();

    public void ExibirBandas()
    {
        Console.WriteLine($"\nNomes das Bandas:\n");
        foreach (var banda in nomeDasBandas)
            Console.WriteLine($"-> {banda}");
    }
}
```
***No ``foreach()`` pode ser omitido as chaves ``{}`` quando for executa apenas uma unica linha dentro do metod, caso aja mais de uma linha de codigo dentro 
do ``Foreach()`` e preciso usar as chaves ``{}`` no ``Foreach()``. <br><br>
A palavra reservada ``void`` indica que o metodo não terá nenhum tipo de retorno, tais como `numero inteiro`, `string`, `booleano` ou algo
que necessita da palavra ``return`` explicita no final do metodo, ou seja, quando não há a necessidade de usar a palavra reserda ``return``
no metodo usamos ``void``, caso use ``return`` deve informa o tipo do retorno (``int``, ``string``, ``bool``, etc...)***

<br>

<div align="center">
    :octocat: Feito por Mateus Barros :octocat:
</div>

---
