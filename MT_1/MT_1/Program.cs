using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_1
{
    enum Menu
    {
        PlayGame = 1, Exit //สร้างลำดับเมนู
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen();
            Console.ReadLine();
        }

        static void PrintHeaderGame() //แสดงข้อมูลต้อนรับเข้าเกม
        {
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
        }

        static void PrintListMenu() //แสดงข้อมูลเมนู
        {
            Console.WriteLine("1.Play game");
            Console.WriteLine("2.Exit");
        }

        static void InputMenuFromKeyboard() //รับค่าเมนูจากคีย์บอร์ด
        {
            Console.Write("Please Select Menu :");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);

        }

        static void PrintMenuScreen() //แสดงข้อมูลต้อนรับ เมนู รับค่าเมนูจกคีย์บอร์ด
        {
            Console.Clear();
            PrintHeaderGame();
            PrintListMenu();
            InputMenuFromKeyboard();
        }

        static void ShowGameScreen() //หน้าแสดงผลเกม
        {
            Console.Clear();
            PrintHeaderPlayGame();

            Console.Clear();
            PlayGame();


        }

        static void PrintHeaderPlayGame() //แสดงชื่อเกม
        {
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("-----------------------");
        }

        static void PresentMenu(Menu menu) //นำค่าที่รับมาจากคีย์บอร์ดมาแสดงเพื่อไปเมนูต่างๆ
        {
            if (menu == Menu.PlayGame)
            {
                ShowGameScreen();
            }
            else if (menu == Menu.Exit)
            {
                Exit();
            }
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }

        static void Exit() //ออกจากระบบ
        {

        }

        static void ShowMessageInputMenuIsInCorrect() //ถ้าไม่ได้กรอกเลข1หรือ2ให้กรอกใหม่
        {
            Console.Clear();
            Console.WriteLine("Menu Incorrect Please try again.");
            InputMenuFromKeyboard();
        }

        static void Process() //กระบวนการของเกม
        {
            int live = 6; //กำหนดค่าเริ่มต้นต่างๆ
            bool win = false;
            int lettersRevealed = 0;
            int Incorrect = 0;

            Random random = new Random(); //ใช้สุ่มคำ
            string[] WordBank = new string[3] { "tennis", "football", "badminton" };
            string WordToGuess = WordBank[random.Next(0, WordBank.Length)];
            StringBuilder displayToPlay = new StringBuilder(WordToGuess.Length);

            List<char> correctGuesses = new List<char>(); //เก็บอักษรที่ตอบถูกเป็นlist
            List<char> incorrectGuesses = new List<char>(); //เก็บอักษรที่ตอบผิดเป็นlist

            string input;
            char guess;

            Console.Clear();

            PrintHeaderPlayGame();
            for (int i = 0; i < WordToGuess.Length; i++) //แสดง-ตามจำนวนตัวอักษรของคำนั้น แล้วเมื่อตอบถูกจะถูกแทนที่ด้วยตัวอักษรนั้น
            {
                displayToPlay.Append('-');
            }

            while (!win && live > 0 && Incorrect < 7)
            {

                for (int i = 0; i < WordToGuess.Length; i++) //แสดง-ตามจำนวนตัวอักษรของคำนั้น
                {
                    Console.Write('-');
                }

                Console.WriteLine("\nIncorrect Score : {0}", Incorrect); //แสดงจำนวนครั้งที่ตอบผิด
                Console.Write("Input letter alphabet : "); //กรอกตัวอักษร
                input = Console.ReadLine();
                guess = input[0];
                Console.Clear();
                PrintHeaderPlayGame();

                if (WordToGuess.Contains(guess))
                {

                    correctGuesses.Add(guess); //แสดงผลตัวที่ตอบถูก

                    for (int i = 0; i < WordToGuess.Length; i++)
                    {
                        if (WordToGuess[i] == guess)
                        {
                            displayToPlay[i] = WordToGuess[i];
                            lettersRevealed++;
                        }
                    }

                    if (lettersRevealed == WordToGuess.Length)
                        win = true;
                }

                else
                {
                    incorrectGuesses.Add(guess); //นับครั้งที่ตอบผิด
                    Incorrect++;

                }
                Console.WriteLine(displayToPlay.ToString());

                if (win) //ถ้ากรอกถูกหมดทุกตัวจะแสดงYou win!!
                {                   
                    Console.WriteLine("You win!!");
                    Exit();
                }

                else if (Incorrect == 7) //ถ้ากรอกผิดเกิน6ครั้งจะแสดง Game Over และคำตอบที่ถูก
                {                    
                    Console.WriteLine(WordToGuess);
                    Console.WriteLine("Game Over", WordToGuess);
                    Exit();
                }
            }
        }

        static void PlayGame()
        {
            PrintHeaderPlayGame();
            Process(); //แสดงกระบวนการของเกม
        }

    }
}
