
class Program
{
    static void Main(string[] args)
    {
        var people = new Dictionary<int, List<string>>();
        people[5] = new List<string>(){ "Tom"} ;
        people[6] = new List<string>() { "Sam" };
        people[7] = new List<string>() { "Bob" };

        List<string> sam = people[6];
        sam.Add("Keivin");
        sam.Sort();
        sam = people[7];
        sam.Add("Dima");

        var contacts = new List<string>();

        contacts.Add("Sasha:sasha@gmail.com");
        contacts.Add("Sancho:sancho@mail.ru");
        contacts.Add("Roma:roma@gmail.com");
        contacts.Add("Gusein:gusein@mail.com");
        contacts.Add("G:gusein@mail.com");
        contacts.Add(":");
        contacts.Add("");
        contacts.Add("Gusein:");
        contacts.Add("Gu:gusein@mail.com");
        contacts.Add("G:gusein@mail.com");
        contacts.Add("Roma:4567@gmail.com");
        contacts.Add("Sasha:sa@gm.com");
        contacts.Add(":gusein@mail.com");
        contacts.Add("Roma:");
        contacts.Add($"{null}:sa@gm.com:priz@rty.com");
        contacts.Add($"{null}:{null}");
        contacts.Add($"Sasha:{null}");
        contacts.Add(":gusein@mail.com");
        contacts.Add("Roma:");

        UsefulAcquaintances.OptimizeContacts(contacts);
    }

}