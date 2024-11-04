using P4_2_714230037.Characters;

namespace P4_2_714230037.Items;

internal class Trap {
    private readonly int _damage;
    private readonly string _type;

    public Trap() {
        string[] trapTypes = { "Spike", "Poison Gas", "Arrow", "Fire" };
        _type = trapTypes[new Random().Next(trapTypes.Length)];
        _damage = new Random().Next(10, 26);
    }

    public void Trigger(Character target) {
        Console.WriteLine($"A {_type} trap was triggered!");
        target.TakeDamage(_damage);
    }
}