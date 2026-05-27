namespace ASPCORETUT.Endpoints;

using ASPCORETUT.Dtos;

public static class GameEndpoints
{
    private static readonly List<GameDto> games = [
    new (
        1,
        "Street Fighter II",
        "Fighting",
        19.99M,
        new DateOnly(1992,7,15)
    ),

    new (
        2,
        "FInal 2nd II",
        "Role Playing",
        19.99M,
        new DateOnly(2019,7,15)
    ),

    new (
        3,
        "FIFA Fighter II",
        "Fighting",
        12.9M,
        new DateOnly(2005,7,15)
    ),
];

    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("games");
        const string GetGameEndPointName = "GetGame";



        group.MapGet("/", () => games);

        group.MapGet("/{id}", (int id) =>
        {
            GameDto? game = games.Find(game => game.Id == id);
            return game is null ? Results.NotFound() : Results.Ok(game);
        })
        .WithName(GetGameEndPointName);

        group.MapPost("/", (CreateGameDto newGame) =>
        {
            GameDto game = new(
                games.Count + 1,
                newGame.Name,
                newGame.Genre,
                newGame.Price,
                newGame.ReleaseDate
            );

            games.Add(game);

            return Results.CreatedAtRoute(GetGameEndPointName, new { Id = game.Id }, game);
        });


        group.MapPut("/{id}", (int id, UpdateGameDto updateGame) =>
        {
            var gameOld = games.Find(game => game.Id == id);
            if (gameOld is null)
            {
                return Results.NotFound();
            }

            var idx = games.FindIndex(game => game.Id == id);

            games[idx] = new GameDto(
                id,
                updateGame.Name,
                updateGame.Genre,
                updateGame.Price,
                updateGame.UpdateDate
            );

            return Results.Ok(games[idx]);
        });


        group.MapDelete("/{id}", (int id) =>
        {
            var idx = games.FindIndex(game => game.Id == id);

            if (idx == -1)
            {
                // System.Console.WriteLine("id not found!");
                return Results.NoContent();
            }
            games.RemoveAt(idx);
            return Results.NoContent();
        });

        return group;
    }

}