using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangybangymannetje
{
    internal class hangyman
    {
        public List<string> words = new List<string>();
        public List<guessedthings> guessed = new List<guessedthings>();
        public List<guessedthings> guessed2 = new List<guessedthings>();

        public struct guessedthings()
        {
            public char letter;
            public bool good;
        }
        public string bars;
        public int lives = 3;
        public string input;
        public string correctword;
        public string compareword;
        public bool gamewon = false;

        int correctletters;
        

        string stringtodraw;
        List<char> cA;
        List<char> cAg;
        public hangyman()
        {
            
            using (StreamReader r = new StreamReader(@"words.txt"))
            {
                words.Add(r.ReadLine());    
                words.Add(r.ReadLine());    
                words.Add(r.ReadLine());    
                words.Add(r.ReadLine());    
                words.Add(r.ReadLine());    
            }
            Random rnd = new Random();
            correctword = words[rnd.Next(words.Count)];
            cA = new List<char>();
            cAg = new List<char>();

        }
        public void hangedmangame()
        {
            
            while (!gamewon && lives > 0)
            {
                Draw();
                input = Console.ReadLine().ToLower();
                //Console.WriteLine(input);
                if (input.Length > 1)
                {
                    foreach (char c in input)
                    {
                        if (!char.IsLetter(c))
                        {
                            return;
                        }
                        else
                        {
                            if (string.Compare(input, correctword) == 0)
                            {
                                gamewon = true;
                                Console.WriteLine("you win");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("nuh uh");
                                return;
                            }
                        }
                    }
                }
                else if (input.Length == 1)
                {
                    foreach (char c in input)
                    {
                        if (!char.IsLetter(c))
                        {
                            return;
                        }
                        else
                        {
                            guessedthings guess = new guessedthings();
                            guess.letter = input.ToCharArray()[0];

                            foreach(var g in guessed)
                            {
                                if (guess.letter == g.letter)
                                {
                                    Console.WriteLine("al geraden");
                                    
                                }
                                
                            }
                            for (int a = 0; a < correctword.Length; a++)
                            {
                                if (guess.letter == correctword.ToCharArray()[a])
                                {
                                    guess.good = true;
                                    guessed.Add(guess);
                                }
                                if (!correctword.Contains(guess.letter))
                                {
                                    cA.Add(guess.letter);
                                    cA = cA.Distinct().ToList();
                                    if (cA.Count >= lives)
                                    {
                                        Console.WriteLine("died");
                                        lives = 0;
                                    }
                                }
                                
                            }


                        }
                    }
                    
                    
                }
                
                foreach(var g in guessed)
                {
                    if (g.good)
                    {
                        cAg.Add(g.letter);
                    }
                    
                }
                
                
                
                
                

            }
            
        }

        public void Draw()
        {
            
            Console.Clear();
            Console.WriteLine(lives - cA.Count);
            for (int a = 0;a < correctword.Length; a++)
            {
                
                if (cAg.Contains(correctword[a]))
                {
                    Console.WriteLine(correctword[a]);
                    compareword += correctword[a];
                }
                else
                {
                    Console.WriteLine("_");
                }
                if (compareword == correctword)
                {
                    Console.WriteLine("win");
                    gamewon = true;

                }

            }
            Console.WriteLine(compareword);
            
            compareword = "";


        }
    }
}
