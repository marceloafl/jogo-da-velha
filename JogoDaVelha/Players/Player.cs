using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.Players
{
    public class Player
    {
        public string Name;
        //public List<int> SelectedSpots = new List<int>();
        public int PlayerType { get; set; }
        public char Symbol { get; set; }
        public Player(int playerType)
        {
            this.PlayerType = playerType;
        }


        public void ChooseSymbol()
        {
            if(this.PlayerType == 1)
            {
                Console.WriteLine("Digite a letra para escolher o símbolo do Player 1 nas marcações do jogo e tecle enter.");
                int pressedKey = Console.ReadLine()[0];
                if(pressedKey >= 65 && pressedKey <= 90 || pressedKey >= 97 && pressedKey <= 122)
                {
                    char playerASymbol = Char.ToUpper((char)pressedKey);
                    this.Symbol = playerASymbol;
                    Console.WriteLine(); ;
                    Console.WriteLine($"Player 1, seu símbolo será {this.Symbol} \n");
                }
                else
                {
                    Console.WriteLine("Por favor, escolha uma letra");
                    ChooseSymbol();
                }
                this.Name = "Player 1";

                
            }
            else
            {
                Console.WriteLine("Agora é hora de escolher o símbolo do Player 2. Digite a letra desejada.");
                int pressedKey = Console.ReadLine()[0];
                if (pressedKey >= 65 && pressedKey <= 90 || pressedKey >= 97 && pressedKey <= 122)
                {
                    char playerBSymbol = Char.ToUpper((char)pressedKey);
                    this.Symbol = playerBSymbol;
                    Console.WriteLine();
                    Console.WriteLine($"Player 2, seu símbolo será {this.Symbol} \n");
                }
                else
                {
                    Console.WriteLine("Por favor, escolha uma letra");
                    ChooseSymbol();
                }
                this.Name = "Player 2";

            }
        }


    

    }
}
