namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    // 4. Crie a funcionalidade de buscar jogos desenvolvidos por um estúdio de jogos
    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        IEnumerable<Game> filteredGames = from game in Games
                          where game.DeveloperStudio == gameStudio.Id
                          select game;

        return filteredGames.ToList();
    }

    // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
    public List<Game> GetGamesPlayedBy(Player player)
    {
        IEnumerable<Game> gamesPlayed = from game in Games
                                        where player.GamesOwned.Contains(game.Id)
                                        select game;
        
        return gamesPlayed.ToList();
    }

    // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        IEnumerable<Game> gamesPlayed = from game in Games
                                        join gameId in playerEntry.GamesOwned
                                        on game.Id equals gameId
                                        select game;
        
        return gamesPlayed.ToList();
    }


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        IEnumerable<GameWithStudio> gamesWithStudio = from game in Games
                                                  join studio in GameStudios
                                                  on game.DeveloperStudio equals studio.Id
                                                  select new GameWithStudio {
                                                    GameName = game.Name,
                                                    StudioName = studio.Name,
                                                    NumberOfPlayers = game.Players.Count()
                                                  };
        
        return gamesWithStudio.ToList();
    }
    
    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
