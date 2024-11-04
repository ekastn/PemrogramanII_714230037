namespace P4_2_714230037.Characters;

internal abstract class Character {
    protected int AttackPower;
    protected int CurrentHp;
    protected int Defense;
    protected int MaxHp;
    protected int MaxSpecialCooldown;
    protected int SpecialCooldown;
    protected int StunDuration;

    public Character(string name, int maxHp, int attackPower, int defense, int maxSpecialCooldown) {
        Name = name;
        MaxHp = maxHp;
        CurrentHp = maxHp;
        AttackPower = attackPower;
        Defense = defense;
        MaxSpecialCooldown = maxSpecialCooldown;
    }

    public string Name { get; }

    public abstract void UseSpecialAbility(Character target);

    public virtual int CalculateDamage() {
        return AttackPower;
    }

    public void Attack(Character target) {
        Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage!");
        target.TakeDamage(AttackPower);
    }

    public void TakeDamage(int damage) {
        int actualDamage = Math.Max(1, damage - Defense);
        CurrentHp = Math.Max(0, CurrentHp - actualDamage);
        Console.WriteLine($"{Name} takes {actualDamage} damage!");
        Thread.Sleep(1000);
    }

    public bool IsAlive() {
        return CurrentHp > 0;
    }

    public void Heal(int amount) {
        CurrentHp = Math.Min(MaxHp, CurrentHp + amount);
        Console.WriteLine($"{Name} heals for {amount} HP!");
    }

    public string GetStats() {
        string cooldownStatus = SpecialCooldown > 0 ? $"(Special: {SpecialCooldown} turns)" : "(Special: Ready!)";
        string stunStatus = IsStunned() ? " (Stunned)" : "";
        return $"{Name}: HP {CurrentHp}/{MaxHp} {cooldownStatus}{stunStatus}";
    }

    public bool CanUseSpecial() {
        return SpecialCooldown == 0;
    }

    public void UpdateCooldown() {
        if (SpecialCooldown > 0) SpecialCooldown--;
    }

    protected void StartCooldown() {
        SpecialCooldown = MaxSpecialCooldown;
    }

    public void Stun(int duration) {
        StunDuration = duration;
        Console.WriteLine($"{Name} is stunned for {duration} turns!");
    }

    public bool IsStunned() {
        return StunDuration > 0;
    }

    public void UpdateStun() {
        if (StunDuration > 0) {
            StunDuration--;
            if (StunDuration == 0) Console.WriteLine($"{Name} is no longer stunned!");
        }
    }
}