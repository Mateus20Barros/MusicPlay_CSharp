class Banda
{
    public Banda(string nomeBanda)
    {
        NomeBanda = nomeBanda;
    }

    private List<Album> albums = new List<Album>();

    public string NomeBanda { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da Banda - {NomeBanda}.");

        foreach(Album album in albums)
        {
            Console.WriteLine($"# Nome do album - {album.Nome}");
        }
    }
}
