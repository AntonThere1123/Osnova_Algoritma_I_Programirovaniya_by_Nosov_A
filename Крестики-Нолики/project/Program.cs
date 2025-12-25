using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestiki
{
    internal class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Массив доски
        static int currentPlayer = 1; // 1 - крестик (X), 2 - нолик (O)


        static void DrawBoard() // Метод для "появления доски", коротко - доска
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine(" ———————");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine(" ———————");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }


        static bool VictoryG() // Метод для определения победы
        {
            return
                // Горизонталь
                (board[0] == board[1] && board[1] == board[2]) ||
                (board[3] == board[4] && board[4] == board[5]) ||
                (board[6] == board[7] && board[7] == board[8]) ||

                // Вертикаль
                (board[0] == board[3] && board[3] == board[6]) ||
                (board[1] == board[4] && board[4] == board[7]) ||
                (board[2] == board[5] && board[5] == board[8]) ||

                // Диагональ
                (board[0] == board[4] && board[4] == board[8]) ||
                (board[2] == board[4] && board[4] == board[6]);
        }

        static bool DrawG() // Определение ничьи
        {
            foreach (char cell in board)
            {
                if((cell != 'X') && (cell != 'O'))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args) // Маин
        {

            int tem_choice; // Сюда залетает проверенное число на тип данных
            bool validInput; // Сюда залетает тру фалсе, ещё одна проверка, если проходит, то всё по кайфу


            // Цикл всей игры
            do
            {
                // Очистка консоли для более чистого и понятного интерфейса
                Console.Clear();
              
                // Вывод доски
                DrawBoard();

                // Вывод какому игроку нужно выбирать ячейку
                Console.WriteLine($"Игрок {currentPlayer}, введите номер ячейки");

                // ОСНОВНАЯ ПРОВЕРКА: проверяет что за тип, число и не занято ли
                validInput = int.TryParse(Console.ReadLine(), out tem_choice) && tem_choice >= 1 && tem_choice <= 9 && board[tem_choice - 1] != 'X' && board[tem_choice - 1] != 'O';

                // Вывод проверки (если неправильно)
                if(!validInput)
                {
                    Console.WriteLine("Некорректный ввод!");
                    continue;
                }

                // Ставим X или O
                board[tem_choice - 1] = (currentPlayer == 1 ? 'X' : 'O');


                // Вызов победы
                if (VictoryG())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"\nИгрок {currentPlayer} победил!");
                    break;
                }

                // Вызов ничьи
                if (DrawG())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("\nНичья!");
                    break;
                }

                // Переход хода к другому игроку
                currentPlayer = (currentPlayer == 1 ? 2 : 1);


            } while (true);
            
        }
    }
}