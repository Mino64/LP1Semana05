using System;
using System.Security.Cryptography.X509Certificates;

namespace DungeonStats
{
    public class Program
    {
       
        private static void Main(string[] args)
        {
            int savedDef = Convert.ToInt32(args[1]);
        }

        private static int Damage(int attack, int defense)
        {
    
            if((attack - defense) < 0)
            {
                return 0;
            }
            else
            {
                return attack - defense;
            }
        }
        private static int Damage(int attack)
        {
                return attack;
            }

        private static int CriticalHit(int damage)
        {
            if(damage <= 0)
            {
                return 0;
            }
            else
            {
                return 1 + CriticalHit(Damage(damage, damage));
            }
        }

        }

    } 
