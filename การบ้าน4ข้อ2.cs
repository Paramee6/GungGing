using System;

namespace ข้อ2
{
    class Program
    {
        static viod Main()
        {
            Console.Write("Current half DNA sequence : ");
            string halfDNASequence = Console.ReadLine().ToUpper();
            char[] nucleotide = halfDNASequence.ToCharArray();
            if (IsValidSequence(halfDNASequence) == false)
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }
            else
            {
                Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                char YorN1 = char.Parse(Console.ReadLine());
                switch (YorN1)
                {  
                    default:
                        do
                        { 
                            Console.WriteLine("Please input Y or N :");
                            YorN1 = char.Parse(Console.ReadLine());
                        } while (YorN1 == 'N' && YorN1 == 'n' && YorN1 == 'Y' && YorN1 == 'y');
                        if (YorN1 == 'Y' && YorN1 == 'y')
                        {
                            Console.WriteLine("Replicate half DNA sequence :{0}", ReplicateSequence(halfDNASequence));
                        }
                        break;
                    case 'Y':
                        Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSequence(halfDNASequence));
                        break
                    case 'N':
                        break;
                    case 'n': 
                        break;           
                }
            }
            Console.Write("Do you want to procedd another sequence ? (Y/N) : ");
            char YorN2 = char.Parse(Console.ReadLine());
            switch (YorN2)            
            {                
                default:
                    do
                    {
                        Console.WriteLine("Please input Y or N : ");
                        YorN2 = char.Parse(Console.ReadLine());
                    }while (YorN2 == 'N' && YorN2 == 'n' && YorN2 == 'Y' && YorN2 == 'y');
                    if (YorN2 == 'Y' && YorN2 == 'y')
                    {
                        Main();
                    }
                    break;
                case 'Y':
                    Main();    
                    break
                case 'N':
                    break;
                case 'n': 
                    break;         
            }
        }
        static string ReplicateSequence(string halfDNASequence)
        {
            string result = "";
            foreach (char necleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".Indexof(nucleotide)];
            }
            return result;
        }
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(necleotide))
                {
                    return false;
                }
            }
            return true;
        }
    }
}        