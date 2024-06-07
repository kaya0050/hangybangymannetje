using static cards.Program;

namespace cards
{
    internal class Program
    {
        public class hand()
        {
            public List<card> da_hand = new List<card>();
            public int valuehand;
        }
        public struct card
        {
            public int value;
            public enum soort { harten,schoppen,ruiten,klaver}
            public soort soortje;
            public bool special;
            public enum specialsoort { joker, koning, koningin, boer, ace }
            public specialsoort specialsoorttje;

        }
        public class Decky()
        {
            public List<card> da_deck;

            public void Addcards()
            {
                da_deck = new List<card>();
                Addharten(da_deck);
                Addschoppen(da_deck);
                Addruiten(da_deck);
                Addklaver(da_deck);
                Console.WriteLine(da_deck.Count);
                
            }
            public void Addharten(List<card> deck)
            {
                //add harten
                for (int i = 2; i <= 10; i++)
                {
                    card card = new card();
                    card.value = i;
                    card.soortje = card.soort.harten;
                    da_deck.Add(card);
                }
                //add ace harten
                card card1 = new card();
                card1.value = 1;
                card1.soortje = card.soort.harten;
                card1.special = true;
                card1.specialsoorttje = card.specialsoort.ace;
                deck.Add(card1);

                //add koning
                card card2 = new card();
                card2.value = 10;
                card2.soortje = card.soort.harten;
                card2.special = true;
                card2.specialsoorttje = card.specialsoort.koning;
                deck.Add(card2);

                //add koningin
                card card3 = new card();
                card3.value = 10;
                card3.soortje = card.soort.harten;
                card3.special = true;
                card3.specialsoorttje = card.specialsoort.koningin;
                deck.Add(card3);

                //add boer
                card card4 =  new card();
                card4.value = 10;
                card4.soortje = card.soort.harten;
                card4.special = true;
                card4.specialsoorttje = card.specialsoort.boer;
                deck.Add(card4);

            }
            public void Addschoppen(List<card> deck)
            {
                //add harten
                for (int i = 2; i <= 10; i++)
                {
                    card card = new card();
                    card.value = i;
                    card.soortje = card.soort.schoppen;
                    da_deck.Add(card);
                }
                //add ace harten
                card card1 = new card();
                card1.value = 1;
                card1.soortje = card.soort.schoppen;
                card1.special = true;
                card1.specialsoorttje = card.specialsoort.ace;
                deck.Add(card1);

                //add koning
                card card2 = new card();
                card2.value = 10;
                card2.soortje = card.soort.schoppen;
                card2.special = true;
                card2.specialsoorttje = card.specialsoort.koning;
                deck.Add(card2);

                //add koningin
                card card3 = new card();
                card3.value = 10;
                card3.soortje = card.soort.schoppen;
                card3.special = true;
                card3.specialsoorttje = card.specialsoort.koningin;
                deck.Add(card3);

                //add boer
                card card4 = new card();
                card4.value = 10;
                card4.soortje = card.soort.schoppen;
                card4.special = true;
                card4.specialsoorttje = card.specialsoort.boer;
                deck.Add(card4);

            }
            public void Addruiten(List<card> deck)
            {
                //add harten
                for (int i = 2; i <= 10; i++)
                {
                    card card = new card();
                    card.value = i;
                    card.soortje = card.soort.ruiten;
                    da_deck.Add(card);
                }
                //add ace harten
                card card1 = new card();
                card1.value = 1;
                card1.soortje = card.soort.ruiten;
                card1.special = true;
                card1.specialsoorttje = card.specialsoort.ace;
                deck.Add(card1);

                //add koning
                card card2 = new card();
                card2.value = 10;
                card2.soortje = card.soort.ruiten;
                card2.special = true;
                card2.specialsoorttje = card.specialsoort.koning;
                deck.Add(card2);

                //add koningin
                card card3 = new card();
                card3.value = 10;
                card3.soortje = card.soort.ruiten;
                card3.special = true;
                card3.specialsoorttje = card.specialsoort.koningin;
                deck.Add(card3);

                //add boer
                card card4 = new card();
                card4.value = 10;
                card4.soortje = card.soort.ruiten;
                card4.special = true;
                card4.specialsoorttje = card.specialsoort.boer;
                deck.Add(card4);

            }
            public void Addklaver(List<card> deck)
            {
                //add harten
                for (int i = 2; i <= 10; i++)
                {
                    card card = new card();
                    card.value = i;
                    card.soortje = card.soort.klaver;
                    da_deck.Add(card);
                }
                //add ace harten
                card card1 = new card();
                card1.value = 1;
                card1.soortje = card.soort.klaver;
                card1.special = true;
                card1.specialsoorttje = card.specialsoort.ace;
                deck.Add(card1);

                //add koning
                card card2 = new card();
                card2.value = 10;
                card2.soortje = card.soort.klaver;
                card2.special = true;
                card2.specialsoorttje = card.specialsoort.koning;
                deck.Add(card2);

                //add koningin
                card card3 = new card();
                card3.value = 10;
                card3.soortje = card.soort.klaver;
                card3.special = true;
                card3.specialsoorttje = card.specialsoort.koningin;
                deck.Add(card3);

                //add boer
                card card4 = new card();
                card4.value = 10;
                card4.soortje = card.soort.klaver;
                card4.special = true;
                card4.specialsoorttje = card.specialsoort.boer;
                deck.Add(card4);

            }
        }
        static void Main(string[] args)
        {
            Decky decky = new Decky();
            decky.Addcards();
            Draw(decky);
            /*foreach(var card in decky.da_deck)
            {
                if (card.special)
                {
                    Console.WriteLine(card.specialsoorttje);
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
                else
                {
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
            }*/

            
        }
        static void Draw(Decky decky)
        {
            Random rnd = new Random();
            hand hand = new hand();
            hand dealerhand = new hand();
            //your first draw
            for (int i = 0; i < 2; i++)
            {
                int draw = rnd.Next(decky.da_deck.Count -1);
                hand.da_hand.Add(decky.da_deck[draw]);
                decky.da_deck.Remove(decky.da_deck[draw]);
                

            }
            foreach (var card in hand.da_hand)
            {
                hand.valuehand += card.value;
            }



            //dealer first draw
            for (int i = 0; i < 2; i++)
            {

                int draw = rnd.Next(decky.da_deck.Count -1);
                dealerhand.da_hand.Add(decky.da_deck[draw]);
                decky.da_deck.Remove(decky.da_deck[draw]);
                

            }
            foreach (var card in dealerhand.da_hand)
            {
                dealerhand.valuehand += card.value;
            }


             //write values
            Console.WriteLine("your cards");
            Console.WriteLine("value" + hand.valuehand);
            foreach (var card in hand.da_hand)
            {
                if (card.special)
                {
                    
                    Console.WriteLine(card.specialsoorttje);
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
                else
                {
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
            }
            Console.WriteLine("\n"+"dealer card");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(dealerhand.da_hand[0].value);
                Console.WriteLine(dealerhand.da_hand[0].soortje);
                if (dealerhand.da_hand[0].special)
                {
                    Console.WriteLine(dealerhand.da_hand[0].specialsoorttje);
                }
                
               
            }


            Console.ReadLine();
            Console.Clear();
            Drawagain(hand,rnd,decky,dealerhand);





            
        }
        public static void Drawagain(hand hand,Random rnd, Decky decky,hand dealerhand)
        {
            
            if (dealerhand.valuehand < 17)
            {
                int draw = rnd.Next(decky.da_deck.Count - 1);
                dealerhand.da_hand.Add(decky.da_deck[draw]);
                decky.da_deck.Remove(decky.da_deck[draw]);
                dealerhand.valuehand += (decky.da_deck[draw].value);
            }


            if (hand.valuehand < 21)
            {
                Console.WriteLine("[1] draw again other input = hold");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    int draw = rnd.Next(decky.da_deck.Count - 1);
                    hand.da_hand.Add(decky.da_deck[draw]);
                    decky.da_deck.Remove(decky.da_deck[draw]);
                    hand.valuehand += (decky.da_deck[draw].value);
                }

            }

            Console.WriteLine("your cards");
            Console.WriteLine("value" + hand.valuehand);
            foreach (var card in hand.da_hand)
            {
                if (card.special)
                {

                    Console.WriteLine(card.specialsoorttje);
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
                else
                {
                    Console.WriteLine(card.soortje);
                    Console.WriteLine(card.value);
                }
            }
            Console.WriteLine("\n" + "dealer card");

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(dealerhand.da_hand[0].value);
                Console.WriteLine(dealerhand.da_hand[0].soortje);
                if (dealerhand.da_hand[0].special)
                {
                    Console.WriteLine(dealerhand.da_hand[0].specialsoorttje);
                }


            }




            if (dealerhand.valuehand >= 21)
            {
                if (dealerhand.valuehand == 21)
                {
                    Console.WriteLine("lost");
                    return;
                }
                Console.WriteLine("win");
                return;
            }
            if (hand.valuehand >= 21)
            {
                if (hand.valuehand == 21)
                {
                    Console.WriteLine("win");
                    return;
                }
                Console.WriteLine("lost");
                return;
            }
            else if (dealerhand.valuehand > hand.valuehand)
            {
                Console.WriteLine("lost");
                return;
            }
            else if (dealerhand.valuehand < hand.valuehand)
            {
                Console.WriteLine("win");
                return;
            }
            else if (dealerhand.valuehand == hand.valuehand)
            {
                Console.WriteLine("draw");
                return;
            }
        }
    }
}
