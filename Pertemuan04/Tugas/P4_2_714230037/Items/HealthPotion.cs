using P4_2_714230037.Characters;

namespace P4_2_714230037.Items;

internal class HealthPotion {
    private readonly int _healAmount;
    private bool _isUsed;

    public HealthPotion() {
        _healAmount = new Random().Next(20, 41);
    }

    public void Use(Character target) {
        if (!_isUsed) {
            target.Heal(_healAmount);
            _isUsed = true;
        } else {
            Console.WriteLine("Potion has already been used!");
        }
    }
}