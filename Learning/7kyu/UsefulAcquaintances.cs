public class UsefulAcquaintances {

    public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();
        string[] temp;
        foreach (var contact in contacts)
        {
            if (contact == "")
            {
                continue;
            }

            temp = contact.Split(':');
            if (temp.Length != 2 || string.IsNullOrWhiteSpace(temp[0]) || string.IsNullOrWhiteSpace(temp[1]) || temp[0].Length <= 1)
            { 
                continue;
            }
            temp[0] = temp[0].Substring(0, 2);
            
            bool check = dictionary.ContainsKey(temp[0]);
            if (check)
            {
                dictionary[temp[0]].Add(templist[0]);
            }
            else 
            {
                List<string> templist = new List<string>() { temp[0] };
                dictionary.Add(temp[0], templist); 
            }

        }
        return dictionary;
    }

}