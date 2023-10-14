class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.DuracaoMusica);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Musicas do album - {Nome}");

        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"# {musica.NomeMusica}");
        }

        Console.WriteLine($">> Tempo de duração do album {DuracaoTotal}.");
    }
}