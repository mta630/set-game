// namespace set
// {
//     public struct Card // data structure instead of object
//     {
//         public Unknown shape;
//         public Unknown color;
//         public Unknown shade;
//         public Unknown number;
//     }

//     public class Set
//     {
//         public bool IsValid();
//         public Unknown SetCardList(Unknown);
//         public Unknown SetSearchTime(Unknown);
//     }

//     public class Deck
//     {
//         public Card Draw();
//         public void Generate();
//         public bool IsEmpty();
//         public void Shuffle();
//     }

//     public class Tabletop
//     {
//         public Unknown AddCard(Unknown);
//         public Unknown RemoveCards(Unknown);
//     }

//     public class Player
//     {
//         public Unknown ClaimSet();
//         public Unknown Score(); // equal to count of completed sets
//         private Unknown<Set> completedSets; // [[card1, card2, card3], [etc]]
//     }

//     public class ComputerPlayer : Player
//     {
//         public Unknown SearchTabletop(Unknown);
//     }

//     public struct GameRound // data structure instead of object?
//     {
//         public Deck deck;
//         public Tabletop tabletop;
//         public Unknown timer;
//         public Unknown<Player> players; // players: []
//     }

//     public class Game
//     {
//         public Unknown NewRound(Unknown);
//         private Unknown<GameRound> gameRounds;
//     }

//     // TO DO: What about our server?

//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             // TO DO
//         }
//     }
// }

public struct Card {
    public string color;
    public string shape;
    public string number;
    public string shade;
}

public class Set {


    public bool IsValid(Card a, Card b, Card c)
    {
        if (validationHelper(a.color, b.color, c.color) && validationHelper(a.shape, b.shape, c.shape) && validationHelper(a.number, b.number, c.number) && validationHelper(a.shade, b.shade, c.shade))
        {
            return true;
        }
        return false;
    }

    public bool validationHelper(string a, string b, string c)
    {
        if (a == b && a == c)
        {
            return true;
        }
        else if (a != b && a != c && b != c)
        {
            return true;
        }
        return false;
    }

}