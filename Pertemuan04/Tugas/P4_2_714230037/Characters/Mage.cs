namespace P4_2_714230037.Characters;

internal class Mage : Character {
    public Mage() : base("Mage", 70, 20, 4, 3) { }

    public override void UseSpecialAbility(Character target) {
        if (!CanUseSpecial()) {
            Console.WriteLine("Special ability is on cooldown!");
            return;
        }

        Console.WriteLine($"{Name} casts Ice Blast!");
        target.TakeDamage(AttackPower * 2);
        target.Stun(2); 
        StartCooldown();
    }
}