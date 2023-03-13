namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of sortedlist  
            SortedList<string, string> bucketList = new SortedList<string, string>();
            //add the elements in sortedlist  
            bucketList.Add("Italy", "Venice");
            bucketList.Add("UK", "England");
            bucketList.Add("France", "Cannes");
            bucketList.Add("Greece", "Athens");
            bucketList.Add("Spain", "Barcelona");
            //display the elements of the sortedlist  
            Console.WriteLine("The items in my sorted bucket list are:");
            foreach (KeyValuePair<string, string> bl in bucketList)
            {
                Console.WriteLine($"Key = {bl.Key}  Value={bl.Value}");
            }
            Console.WriteLine("What city would you like to go to?");
            string city = Console.ReadLine();
            Console.WriteLine("What country is it in?");
            string country = Console.ReadLine();
            //check for value in list
            if (bucketList.ContainsValue(city))
                Console.WriteLine($"{city} is one of the values in your list");
            else
            {
                // check for country key in list (can't have dups)
                if (bucketList.ContainsKey(country))
                {
                    Console.WriteLine($"You can only visit 1 city from {country} ");
                }
                else
                {
                    bucketList.Add(country, city);
                    Console.WriteLine("{city} {country} was added to your list");
                }
            }
        }
    }
}