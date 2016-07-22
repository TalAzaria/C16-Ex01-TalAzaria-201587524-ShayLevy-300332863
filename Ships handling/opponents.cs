using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16_Ex01_Tal_201587524_Shay_300332863
{
    public class Opponents
    {
        public Player player { get; set; }
        public EnemyMotherShip enemyMotherShip { get; set; }
        public List<EnemyMinion> minionsFleet = new List<EnemyMinion>();
        public int NumberOfPinkMinions { get; set; }
        public int NumberOfBlueMinions { get; set; }
        public int NumberOfYellowMinions { get; set; }
        public int NumberOfEnemiesHorizontaly { get; set; }

        public Opponents(int i_NumberOfEnemiesHorizontaly, int i_NumberOfLinesForPinkMinions, int i_NumberOfLinesForBlueMinions,
            int i_NumberOfLinesForYellowMinions)
        {
            player = new Player();
            enemyMotherShip = new EnemyMotherShip();
            NumberOfEnemiesHorizontaly = i_NumberOfEnemiesHorizontaly;
            NumberOfPinkMinions = i_NumberOfLinesForPinkMinions * i_NumberOfEnemiesHorizontaly;
            NumberOfBlueMinions = i_NumberOfLinesForBlueMinions * i_NumberOfEnemiesHorizontaly;
            NumberOfYellowMinions = i_NumberOfLinesForYellowMinions * i_NumberOfEnemiesHorizontaly;

            for (int i=0; i < NumberOfPinkMinions; i++)
            {
                minionsFleet.Add(new EnemyMinionPink());
            }
            for (int i = 0; i < NumberOfBlueMinions; i++)
            {
                minionsFleet.Add(new EnemyMinionBlue());
            }
            for (int i = 0; i < NumberOfYellowMinions; i++)
            {
                minionsFleet.Add(new EnemyMinionYellow());
            }
        }

        public Dictionary<Ship, string> getSprites()
        {
            //Dictionary<Ship, string> listOFTextures = new Dictionary<Ship, Tex>();


            Dictionary<Ship, string> listOFShipsSpriteName = new Dictionary<Ship, string>();
            listOFShipsSpriteName.Add(new Player(), Player.spriteImage);
            listOFShipsSpriteName.Add(new EnemyMotherShip(), EnemyMotherShip.spriteImage);
            listOFShipsSpriteName.Add(new EnemyMinionPink(), EnemyMinionPink.spriteImage);
            listOFShipsSpriteName.Add(new EnemyMinionBlue(), EnemyMinionBlue.spriteImage);
            listOFShipsSpriteName.Add(new EnemyMinionYellow(), EnemyMinionYellow.spriteImage);
            return listOFShipsSpriteName;
        }
    }
}
