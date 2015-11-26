namespace TheSlum.Models.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;

    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, int healthPoints, int defensePoints, int healingPoints, Team team, int range)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = healingPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .OrderBy(c => c.HealthPoints)
                .FirstOrDefault(c => c.Team == this.Team && c != this && c.IsAlive);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }
        
        public override string ToString()
        {
            return $"-- {base.ToString()}, Healing: {this.HealingPoints}";
        }
    }
}
