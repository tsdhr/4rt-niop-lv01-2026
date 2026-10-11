namespace PlayerCards;

// Player nasljeđuje Person
public class Player : Person {
    public Player(string firstName, string lastName, int number) : base(firstName, lastName) {
        Number = number;
    }

    public override string ToString() {
        return $"{base.ToString()} - {Number}";
    }

    public int Number {
        get => field;
        set {
            if (value < 1 || value >= 100) {
                throw new Exception("Broj mora biti između 1 i 100!");
            }
            field = value;
        }
    }
}
