namespace P4_2_714230037.Characters;

internal class Warrior : Character {
    public Warrior() : base("Warrior", 100, 15, 8, 3) { }

    public override void UseSpecialAbility(Character target) {
        if (!CanUseSpecial()) {
            Console.WriteLine("Special ability is on cooldown!");
            return;
        }

        Console.WriteLine($"{Name} uses Stunning Bash!");
        target.TakeDamage(AttackPower * 2);
        target.Stun(1);
        StartCooldown();
    }
}