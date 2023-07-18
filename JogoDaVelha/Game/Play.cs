using JogoDaVelha.GameBoard;
using JogoDaVelha.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Game
{
    public class Play
    {
        public Player Winner;
        //public char WinnersSymbol;
        public Board Board;
        public Player Player1;
        public Player Player2;
        public bool IsPlayer1Turn = true;
        public char CurrentPlayerSymbol;
        public bool Win = false;
        public void StartGame()
        {
            Player player1 = new Player(1);
            this.Player1 = player1;
            player1.ChooseSymbol();

            Player player2 = new Player(2);
            this.Player2 = player2;
            player2.ChooseSymbol();

            Console.WriteLine("Prontos para começar?\nAperte enter para continuar.");
            Console.ReadLine();

            Console.Clear();

            Board board = new Board();
            this.Board = board;
            Console.WriteLine(board.ToString());

            while (!Win)
            {
                Console.WriteLine("Digite o número da casa que deseja marcar \n\n");

                if (IsPlayer1Turn)
                {
                    this.CurrentPlayerSymbol = player1.Symbol;
                }
                else
                {
                    this.CurrentPlayerSymbol = player2.Symbol;
                }

                //foreach (int spot in this.Player2.SelectedSpots)
                //{
                //    Console.WriteLine("spots p2: " + spot);
                //}

                char pressedKey = ChooseSpot();
                char symbol = this.CurrentPlayerSymbol;
                board.ChangeSpot(pressedKey, symbol);

                Console.Clear();
                Console.WriteLine(board.ToString());

                HorizontalVictory();
                VerticalVictory();
                DiagonalVictory();
                ShiftPlayersTurn();
            }
            Console.Clear();
            Console.WriteLine(board.ToString());
            GameOver();
            
        }

        public char ChooseSpot()
        {
            char pressedKey = Console.ReadLine()[0];
            //if (this.IsPlayer1Turn)
            //{
            //    this.Player1.SelectedSpots.Add(int.Parse(pressedKey.ToString()));
            //}
            //else
            //{
            //    this.Player2.SelectedSpots.Add(int.Parse(pressedKey.ToString()));
            //}
            return pressedKey;
        }

        public void ShiftPlayersTurn()
        {
            this.IsPlayer1Turn = !this.IsPlayer1Turn;
            if (this.IsPlayer1Turn)
            {
                Console.WriteLine("Vez do jogador 1");
            } else
            {
                Console.WriteLine("Vez do jogador 2");
            }
        }


        public void HorizontalVictory()
        {
            if (this.Board.Spots[0].Equals(this.Board.Spots[1]) && this.Board.Spots[0].Equals(this.Board.Spots[2]))
            {
                Console.WriteLine("ganhou horizontal top");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
            if (this.Board.Spots[3].Equals(this.Board.Spots[4]) && this.Board.Spots[3].Equals(this.Board.Spots[5]))
            {
                Console.WriteLine("ganhou horizontal center");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
            if (this.Board.Spots[6].Equals(this.Board.Spots[7]) && this.Board.Spots[6].Equals(this.Board.Spots[8]))
            {
                Console.WriteLine("ganhou horizontal bottom");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }

            
        }

        public void VerticalVictory()
        {
            if (this.Board.Spots[0].Equals(this.Board.Spots[3]) && this.Board.Spots[0].Equals(this.Board.Spots[6]))
            {
                Console.WriteLine("ganhou vertical left");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
            if (this.Board.Spots[1].Equals(this.Board.Spots[4]) && this.Board.Spots[1].Equals(this.Board.Spots[7]))
            {
                Console.WriteLine("ganhou vertical center");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
            if (this.Board.Spots[2].Equals(this.Board.Spots[5]) && this.Board.Spots[2].Equals(this.Board.Spots[8]))
            {
                Console.WriteLine("ganhou vertical right");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
        }

        public void DiagonalVictory()
        {
            if (this.Board.Spots[0].Equals(this.Board.Spots[4]) && this.Board.Spots[0].Equals(this.Board.Spots[8]))
            {
                Console.WriteLine("ganhou vertical left");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
            if (this.Board.Spots[2].Equals(this.Board.Spots[4]) && this.Board.Spots[2].Equals(this.Board.Spots[6]))
            {
                Console.WriteLine("ganhou vertical center");
                //this.WinnersSymbol = (char)this.Board.Spots[0];
                this.Win = true;
            }
        }

        public void GameOver()
        {
            if (Win == true)
            {
                if (!this.IsPlayer1Turn)
                {
                    this.Winner = Player1;
                }
                else
                {
                    this.Winner = Player2;
                }
            }
            Console.WriteLine($"Fim de jogo! Vitória do {this.Winner.Name}");
        }


    }
}
