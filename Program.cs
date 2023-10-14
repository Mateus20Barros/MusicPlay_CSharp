

// Criar Banda
Banda nomeBanda = new Banda("Latino Americano");

// Criar Album
Album albumMusica = new Album("MTZ");

// Criar Musica 01
Musica musica01 = new Musica(nomeBanda, "Jamaica")
{
    DuracaoMusica = 125
};

// Criar Musica 02
Musica musica02 = new Musica(nomeBanda, "Una Lady como Tú")
{
    DuracaoMusica = 201
};

albumMusica.AdicionarMusica(musica01);
albumMusica.AdicionarMusica(musica02);
albumMusica.ExibirMusicasAlbum();
nomeBanda.AdicionarAlbum(albumMusica);
nomeBanda.ExibirDiscografia();

musica01.DadosMusical();
musica02.DadosMusical();

Console.ReadLine();

// Codigos Abaixo relacionados a classe "Episodio"

// Criar Episodio 01
Episodio ep1 = new(1, "Tecnicas de facilitacao", 45);
ep1.AdicionarConvidados("Mateus");
ep1.AdicionarConvidados("Barros");
ep1.AdicionarConvidados("Silva");

Console.WriteLine(ep1.Resumo);

// Criar Episodio 02
Episodio ep2 = new(2, "Tecnicas de Aprendizado", 60);
ep2.AdicionarConvidados("Fulano");
ep2.AdicionarConvidados("Siclano");
ep2.AdicionarConvidados("Beltrano");
Console.WriteLine(ep2.Resumo);

// Criar Podcast
Podcast podcast = new("Teste", "Fulano Qualquer");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();

//Console.ReadLine();

