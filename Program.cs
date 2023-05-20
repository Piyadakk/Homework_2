class Program {
    static void Main()
{
    StartProgram(); }
    static void StartProgram()
    {
        Console.Write("Input half DNA sequence: ");
        string halfDNASequence = Console.ReadLine();

        if (IsValidSequence(halfDNASequence))
        {
            Console.WriteLine("Current half DNA sequence: " + halfDNASequence);
            Console.Write("Do you want to replicate it? (Y/N): ");
            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (choice == 'Y')
            {
                string replicatedSequence = ReplicateSequence(halfDNASequence);
                Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
            }
            else if (choice == 'N')
            {

            } else {
                Console.WriteLine("Please input Y or N.");
                Console.Write("Do you want to replicate it? (Y/N): ");
                char choices = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
            }
        } else {
            Console.WriteLine("That half DNA sequence is invalid."); }
            Console.Write("Do you want to process another sequence? (Y/N): ");
            char continueChoice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

        if (continueChoice == 'y'){
            StartProgram();
        }
        else if (continueChoice == 'n')
        {
                Console.WriteLine("Please input Y or N.");
                Console.Write("Do you want to process another sequence? (Y/N): ");
                char choice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
        } else {
        }
    }
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(char.ToUpper(nucleotide)))
            {
                return false;
            }
        }
        return true;
    }
    static string ReplicateSequence(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(char.ToUpper(nucleotide))];
        }
        return result;
    }
}
