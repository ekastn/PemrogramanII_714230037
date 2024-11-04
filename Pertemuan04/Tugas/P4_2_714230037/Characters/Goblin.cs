namespace P4_2_714230037.Characters;

internal class Goblin : Character {
    public Goblin() : base("Goblin", 50, 10, 3, 3) { }

    public override void UseSpecialAbility(Character target) {
        if (CanUseSpecial()) {
            Console.WriteLine($"{Name} uses Club Bash!");
            target.TakeDamage(AttackPower);
            if (new Random().Next(2) == 0) {
                target.Stun(1);
            }

            StartCooldown();
        }
    }
}