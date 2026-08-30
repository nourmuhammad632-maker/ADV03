namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1(Exercise1:)
            //    //1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //    List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //    //2. Print the collection, Count, first and last grade
            //    Console.WriteLine("==================================");
            //    ClassHelper.Printlist("Grades", grades);
            //Console.WriteLine($"Count of list: {grades.Count}\nFirst element :{grades.First()}\nLast Element :{grades.Last()}");
            //    //3. Sort the grades ascending, then print
            //    Console.WriteLine("==================================");
            //    grades.Sort();
            //    ClassHelper.Printlist(" Sorted List ", grades);
            //    //4. Get the first grade above 90
            //    Console.WriteLine("==================================");
            //        int gradeabove = grades.FirstOrDefault(x => x > 90);
            //    Console.WriteLine($"First element above 90: {gradeabove}");
            //    //5. Get all grades below 75 (failing grades)
            //    Console.WriteLine("==================================");
            //    List<int> list = grades.FindAll(x => x < 75);
            //    ClassHelper.Printlist("List Bellow 75 ", list);
            //    // 6.Remove all failing grades(below 75)
            //    Console.WriteLine("==================================");
            //    grades.RemoveAll(x=>x<75);
            //    ClassHelper.Printlist(" Removed List Bellow 75 ", list);
            //    //7. Check if any grade equals 100
            //    Console.WriteLine("==================================");
            //    Console.WriteLine( $"if any grade equale 100 ? { grades.Any(x => x == 100)}");
            //    //8. Create a List<string> where each grade becomes "Grade: X"
            //    Console.WriteLine("==================================");
            //    List<string> strlist = grades.Select(x => $"Grade:{x}").ToList();
            //    ClassHelper.Printlist("string list", strlist);

            #endregion
            #region Question2(Exercise2:)
            ////1. Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona
            //SortedDictionary<int,string> leaderboard =new SortedDictionary<int,string>();
            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");
            ////2. Print all entries (they should be sorted by score automatically)
            //ClassHelper.PrintSortedDictionary("leaderboard", leaderboard);
            ////3. Access the first key and first value
            //Console.WriteLine("============================");
            //int first = leaderboard.Keys. First();
            //string firstval = leaderboard.Values.First();
            //Console.WriteLine($"First Score: {first}");
            //Console.WriteLine($"First Player: {firstval}");
            ////4. Check if score 500 exists
            //Console.WriteLine("============================");
            //Console.WriteLine($"Score 500 exists:{leaderboard.ContainsKey(500)} ");
            ////5. Safely get the player with score 999
            //Console.WriteLine("============================");
            //bool result = leaderboard.TryGetValue(999, out string? vl);
            //Console.WriteLine(result);
            //Console.WriteLine(vl??"Null");
            ////6. Remove the player with score 200 and print the updated list
            //Console.WriteLine("============================");
            //leaderboard.Remove(200);
            //ClassHelper.PrintSortedDictionary("Listed after removed",leaderboard);
            #endregion
            #region Question3(Exercise3:)
            ////1. Create a Collection with 4 contacts (name → phone number)
            //Dictionary<int,string> phones=new Dictionary<int, string>();
            //phones.Add(0112344576, "muhammed");
            //phones.Add(0112678977, "Faten");
            //phones.Add(01271567229, "Nour");
            //phones.Add(0101276438, "khalid");
            //// 2. Add a new contact using [] syntax
            //phones[01223994589] = "Marwan";
            ////3. Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    phones.Add(01271567, "  Nour");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Add Error: " + ex.Message);
            //}
            //// 4. Try adding a duplicate using .TryAdd()
            //bool added = phones.TryAdd(01271567, "  Nour");
            //Console.WriteLine("TryAdd succeeded: " + added);
            ////5. Search for a contact that doesn’t exist
            //bool exists = phones.ContainsKey(012332133);
            //Console.WriteLine($"exist ? {exists}");
            ////6. Get a contact with a fallback of "Not Found"
            //bool geted = phones.TryGetValue(01271567, out string?vl);
            //Console.WriteLine(geted);
            //Console.WriteLine(vl ?? "Null");
            ////7. Print all Keys on one line, then all Values on another line
            //ClassHelper.PrintDictionary("Phone Book", phones);
            #endregion


        }
    }
}
