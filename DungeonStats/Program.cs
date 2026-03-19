using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console;

namespace DungeonStats
{
    public class Program
    {
       
        private static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(args[0]);
            //int num2 = Convert.ToInt32(args[1]);
            int num2 = 2;

           /* if (args[1] == null)
            {
                num2 = 2;
            }
            else
            {
                num2 = Convert.ToInt32(args[1]);
            }*/


            var table = new Table();
  
            // Add columns
            table.AddColumn("Operation");
            table.AddColumn("Result");
  
            // Add rows
            table.AddRow($"Damage({num1})", $"{Damage(num1)}");
            if(args[1] != string.Empty)
            {
                int num3 = Convert.ToInt32(args[1]);
                table.AddRow($"Damage({num1}, {num3})", $"{Damage(num1,num3)}");
                table.AddRow($"CriticalHit({Damage(num1,num3)})", $"{CriticalHit(Damage(num1,num3))}");
            }
            else
            {
                table.AddRow($"Damage({num1}, {num2})", $"{Damage(num1,num2)}");
                table.AddRow($"CriticalHit({Damage(num1,num2)})", $"{CriticalHit(Damage(num1,num2))}");
            //table.AddRow($"CriticalHit({Damage(num1,num2)})", $"{CriticalHit(Damage(num1,num2))}");
                
            }

  
            AnsiConsole.Write(table);
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
                return 1 + CriticalHit(Damage(damage, 2));
                
            
            }
        }

        }

    } 
