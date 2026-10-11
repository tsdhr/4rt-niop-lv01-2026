namespace PlayerCards;

public class Person {
    // konstruktor služi za dovođenje objekta u poznato stanje
    public Person(string firstName, string lastName) {
        FirstName = firstName;
        LastName = lastName;
    }

    // overrideamo ponašanje nasljeđene metode ToString
    public override string ToString() {
        return $"{FirstName} {LastName}";
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}
