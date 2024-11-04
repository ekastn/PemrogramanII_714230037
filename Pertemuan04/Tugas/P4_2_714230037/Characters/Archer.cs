namespace P4_2_714230037.Characters;

internal class Archer : Character {
    public Archer() : base("Archer", 80, 18, 5, 2) { }

    public override void UseSpecialAbility(Character target) {
        if (!CanUseSpecial()) {
            Console.WriteLine("Special ability is on cooldown!");
            return;
        }

        Console.WriteLine($"{Name} uses Rapid Shot!");
        target.TakeDamage(Convert.ToInt16(AttackPower * 2.5));
        StartCooldown();
    }
}