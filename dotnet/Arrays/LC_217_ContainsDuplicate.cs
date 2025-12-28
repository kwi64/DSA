public class LC_217_ContainsDuplicate{

    static bool Question(int[] nums) 
    {
        var solutions = new Func<bool>[]
        {
            () => {
                return true;
            }
        };

        return solutions[0].Invoke();
    }

    static void Main(string[] args)
    {
        bool test1 = Question([1,2,3,1]);
        bool test2 = Question([1,2,3,4]);
        bool test3 = Question([1,1,1,3,3,4,3,2,4,2]);

        Console.WriteLine("{0}, {1}, {2}", test1, test2, test3);
    }
}