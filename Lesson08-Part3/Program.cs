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
            // Random number seed
            Random rnd = new Random();      // creates object of type Random
            int randomCardIndex = 0;

            //Constants
            const int FACE_NUM = 13;
            const int CARD_NUM = 52;
            const int SUIT_NUM = 4;
          

            // Arrays Declaration
            int[] faces = new int[FACE_NUM];      // faces from 1 to 13
            string[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
            string[] deckOfCards = new string[CARD_NUM]; // contains suits and faces

            // Card counter
            int card = 0;
            int position = 0;

            // Card search variable
            string searchCard = "";

            // Search variable
            bool cardFound = false;

            // Initialize faces array
            for (int index  = 0; index < FACE_NUM; index++)
            {
                faces[index] = index + 1;       //  faces begin at 1
            }

            // Create deck of cards
            for (int suit = 0; suit < SUIT_NUM; suit++)
            {
                for (int face = 0; face < FACE_NUM; face++)
                {
                    deckOfCards[card] = faces[face].ToString() + " of " + suits[suit];
                    card++;  // 0 to 51 ( 52 cards )
                } // inner loop
            } // outer loop

            // display deck of cards
            foreach (string showCard in deckOfCards)
            {
                Console.WriteLine( showCard );
            }

            // Display a random card
            Console.WriteLine();
            Console.WriteLine( "And the random card is..." );
            randomCardIndex = rnd.Next( 52 );   // get the next random number from the pool
            Console.WriteLine( deckOfCards[randomCardIndex] );

            // Ask the user for a card to find
            Console.WriteLine(  );
            Console.Write( "Which card do you need?" );
            searchCard = Console.ReadLine();
            Console.WriteLine( $"You entered: {searchCard}" );

            // foreach does not keep track of index
            // Find position fo the card you are searching for
            foreach (string showCard in deckOfCards)
            {
                if (showCard == searchCard)
                {
                    Console.WriteLine( $"\nYour card is at position: {position + 1}" );
                    cardFound = true;
                }
                position++;
            }


            // Output if card not found
            if ( cardFound == false )
            {
                Console.WriteLine("/nSorry, your cant was not found! ");
            }

            // End of program
            Console.WriteLine(  );
            Console.WriteLine( "+++++++++++++++++++++" );
            Console.WriteLine( "Press any key to continue...." );
            Console.ReadKey();
            Console.Clear();
        }
    }
}
