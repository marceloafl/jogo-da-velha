using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha.GameBoard
{
    public class Board
    {
        //int[] spots = new int[9] { 1, 2, 3, 4, 5, 6, 7 ,8 ,9 };
        public ArrayList Spots = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public override string ToString()
        {
            return $"\n" +
                   $"\t \t|\t \t|\t \t" + "\n" +
                   $"\t{Spots[0]}\t|\t{Spots[1]}\t|\t{Spots[2]}\t" + "\n" +
                    $"\t \t|\t \t|\t \t" + "\n" +
                   $"___________________________________________________" + "\n\n" +
                   $"\t \t|\t \t|\t \t" + "\n" +
                   $"\t{Spots[3]}\t|\t{Spots[4]}\t|\t{Spots[5]}\t" + "\n" +
                    $"\t \t|\t \t|\t \t" + "\n" +
                   $"___________________________________________________" + "\n\n" +
                   $"\t \t|\t \t|\t \t" + "\n" +
                   $"\t{Spots[6]}\t|\t{Spots[7]}\t|\t{Spots[8]}\t" + "\n" +
                   $"\t \t|\t \t|\t \t" + "\n"
                   ;
        }

        public void ChangeSpot(char spot,char symbol)
        {
 
            int spotInt = int.Parse(spot.ToString());
            int index = Spots.IndexOf(spotInt);
            this.Spots[index] = symbol;

            
        }
    }

}
