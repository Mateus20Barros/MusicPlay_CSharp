class Musica
{
    public Musica(Banda artista, string nomeMusica)
    {
        NomeArtista = artista;
        NomeMusica = nomeMusica;
    }

    public string NomeMusica { get; }
    public Banda NomeArtista { get; }
    public int DuracaoMusica { get; set; }
    public bool DisponivelPlano { get; set; }

    public string DescricaoResumida => 
        $"A musica {NomeMusica} pertence ao artista {NomeArtista}";

    public void DadosMusical()
    {
        Console.WriteLine($"\nMusica: {NomeMusica}");
        Console.WriteLine($"Artista: {NomeArtista.NomeBanda}");
        Console.WriteLine($"Duracao: {DuracaoMusica}");

        if (DuracaoMusica > 150) DisponivelPlano = false;
        else DisponivelPlano = true;

        if (DisponivelPlano)
            Console.WriteLine(">> Disponivel <<");
        else
            Console.WriteLine(">> Indisponivel <<");
    }
}