using System;

namespace HelpLone_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbarian barbarian = new Barbarian();
            barbarian.Fight();
            barbarian.Slash();
            barbarian.Cleave();
            barbarian.Heal();

            Console.WriteLine();

            Witch witch = new Witch();
            witch.Fight();
            witch.RaiseShield();
            witch.Heal();

            Console.WriteLine();

            Knight knight = new Knight();
            knight.Fight();
            knight.RaiseShield();
            knight.ShieldGlare();
            knight.Die();

            Console.WriteLine();

            Wizard wizard = new Wizard();
            wizard.Fight();
            wizard.Teleport(10, 50);
            wizard.Heal();
            wizard.ThrowFrostNova();
            wizard.ThrowMagicMissile();
            wizard.Die();
            
        }
    }
}
