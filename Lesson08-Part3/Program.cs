using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_Part3
{
    class Program
    {
        static void Main ( string [] args )
        {
            int[] faces = new int[13];      // faces from 1 to 13
            string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
            string[] deckOfCards = new string[52]; // deck of cards
            int card = 0;


            // Initialize faces array
            for (int index  = 0; index < faces.Length; index++)
            {
                faces[index] = index + 1;       //  faces begin at 1
            }

            // Creates deck of cards
            for (int suit = 0; suit < suits.Length; suit++)
            {
                for (int face = 0; face < faces.Length; face++)
                {
                    deckOfCards[card] = faces[face].ToString() + "of" + suits[suit];
                    card++;  // 0 to 51 ( 52 cards )
                } // inner loop
            } // outer loop

            // display deck of cards
            foreach (var i in deckOfCards)
            {
                Console.WriteLine( i );
            }

            Console.WriteLine(  );
            Console.WriteLine( "+++++++++++++++++++++" );
            Console.WriteLine( "Press any key to continue...." );
            Console.ReadKey();
            Console.Clear();
        }
    }
}
