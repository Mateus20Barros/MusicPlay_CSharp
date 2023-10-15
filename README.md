<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="120"/>
</div> <br>

### 📃 Sobre o Projeto

**Projeto desenvolvido em ``CSharp`` com base em stream Musical, onde poderá cadastrar ``Banda``, ``Album`` e ``Musica``.
Há tambem uma classe chamada ``Episodio`` que foi adicionada durante o desenvolvimento do projeto no curso, com foco no stream de filmes.** <br>

**A parte visual do programa e visualizada via ``Terminal``, visto que esse projeto e apenas um pequeno conceito de Orientação a Objeto da linguagem CSharp.**

<br>

### 🔥 Sobre POO Aplicada ao projeto

**Projeto criado na linguagem ``CSharp`` aplicando os principios da POO - Programação Orientada a Objetos, nesse projeto foi aplicado as ``Classes`` que e 01 de 04 pilares 
importantes da Programação Orientada a Objetos.** <br>

```csharp
// Definição de classe em CSharp

public class Banda {
  ...
}
```
<br>

**Tambem foi utilizado ``List<>`` que e uma Collection de objetos fortemente tipada que armazena e acessa os seus valores 
por indice, e possue metodos que classifica, pesquisa e modifica a lista.** <br>

```csharp
// Sintaxe
List<TipoDaLista> nomeDaLista = new List<TipoDaLista>();

// Exemplo
public class Banda
{
    // Forma completa de instanciar uma List.
    public List<string> listaDeBandas = new List<string>();

    // Forma abreviada de instanciar uma List.
    public List<string> nomeDaBanda = new(); 
}
```
<br>

**Outra parte interressante foi os casos de usos dos modificadores de acessos de ``atributos`` e ``metodos`` das classes, tais como:** <br>
**``internal`` - Modificador de acesso padrao se nenhum modificador for especificado.** <br>
**``public`` - Permite que qualquer parte do programa acesse o tipo e os membros** <br>
**``private`` - Permite que apenas codigo da mesma classe ou estruturas (structs) acesse.** <br>
**``protected`` - Permite que a mesma classe e classes derivadas dessa mesma classe acesse seu tipo e membros.** <br>

```csharp
public class Banda
{
    public List<string> nomeDasBandas = new();
    private double ganhosDasBandas;
    protected int quantidadeBandas;
}
```
<br>

**Foi aplicado o uso das propriedades ``get`` e ``set`` nas definições dos atributos das classes.** <br>

```csharp
public class Banda
{
    public List<string> nomeDasBandas = new();
    private double ganhosDasBandas { get; set; }
    protected int quantidadeBandas { get; set; }
}
```
<br>

**Aplicando os conceitos das funçoes ``Lambdas`` com a flecha `=>`.** <br>
 ```csharp
public class Banda
{
    public List<string> nomeDasBandas = new();
    private double ganhosDasBandas { get; set; }
    protected int quantidadeBandas => nomeDasBandas.Count();
}
```
<br>

**Uso do ``Foreach`` para percorrer uma ``List<>`` ao invês do ``for`` tradicional.** <br>
 ```csharp
public class Banda
{
    public List<string> nomeDasBandas = new();
    private double ganhosDasBandas { get; set; }
    protected int quantidadeBandas => nomeDasBandas.Count();

    public void ExibirBandas()
    {
        Console.WriteLine($"\nNomes das Bandas:\n");
        foreach (var banda in nomeDasBandas)
            Console.WriteLine($"-> {banda}");
    }
}
```
> **Nesse ``foreach()`` pode ser omitido as chaves ``{}`` quando for executa apenas uma unica linha, caso aja mais de uma linha de codigo dentro 
> do ``Foreach()`` e preciso usar as chaves ``{}`` no ``Foreach()``.** <br><br>
> **A palavra reservada ``void`` indica que o metodo não terá nenhum tipo de retorno, tais como `numero inteiro`, `string`, `booleano` ou algo
> que necessita da palavra ``return`` explicita no final do metodo, ou seja, quando não há a necessidade de usar a palavra reserda ``return``
> no metodo usamos ``void``, caso use ``return`` deve informa o tipo do retorno (``int``, ``string``, ``bool``, etc...)**

<br>

<div align="center">
    :octocat: Feito por Mateus Barros :octocat:
</div>

---
