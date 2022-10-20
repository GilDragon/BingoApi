var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<int> drawnNums = new List<int>();
int gameSize = 5;

app.MapGet("/", () => "Hello World!");
app.MapGet("/Bingo/Draw", () => DrawNumber());

app.Run();



string DrawNumber() {
    // generate a random number between 1 and 100
    // check if number has already been drawn
    // if drawn, draw new number
    
    if (drawnNums.Count < gameSize) {
        Random rand = new Random();
        var newNum = rand.Next(1, gameSize+1);

    
        while(drawnNums.Contains(newNum)) {
            newNum = rand.Next(1, gameSize+1);
        }

        drawnNums.Add(newNum);
        return $"The number {newNum.ToString()} was drawn";

    } else {
        return $"Sorry {gameSize} numbers have already been drawn";
    }
}