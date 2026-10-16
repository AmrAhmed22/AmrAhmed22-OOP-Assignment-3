namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Egyptian Phone Validation ===");
            Console.WriteLine($"01012345678 -> {"01012345678".IsValidEgyptianPhone()} (Expected: True)");
            Console.WriteLine($"+201512345678 -> {"+201512345678".IsValidEgyptianPhone()} (Expected: True)");
            Console.WriteLine($"01312345678 -> {"01312345678".IsValidEgyptianPhone()} (Expected: False - 013 is not valid)");
            Console.WriteLine($"0101234567 -> {"0101234567".IsValidEgyptianPhone()} (Expected: False - only 10 digits)");
            Console.WriteLine($"0101234567a -> {"0101234567a".IsValidEgyptianPhone()} (Expected: False - contains letter)");
         
            Console.WriteLine($"null -> {((string?)null).IsValidEgyptianPhone()} (Expected: False)");
            Console.WriteLine($"empty -> {("").IsValidEgyptianPhone()} (Expected: False)");
            Console.WriteLine($"space -> {(" ").IsValidEgyptianPhone()} (Expected: False)");




            Console.WriteLine("\n=== Egyptian National ID Validation ===");
            Console.WriteLine($"29901011234567 -> {"29901011234567".IsValidEgyptianNationalId()} (Expected: True)");
            Console.WriteLine($"19901011234567 -> {"19901011234567".IsValidEgyptianNationalId()} (Expected: False - must start with 2 or 3)");
            Console.WriteLine($"2990101123456 -> {"2990101123456".IsValidEgyptianNationalId()} (Expected: False - only 13 digits)");


        }
    }
}
