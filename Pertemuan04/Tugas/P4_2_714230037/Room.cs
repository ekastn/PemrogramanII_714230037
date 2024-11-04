using P4_2_714230037.Characters;
using P4_2_714230037.Items;

namespace P4_2_714230037;

internal class Room {
    public string Description { get; private set; }
    public List<Goblin> Enemies { get; }
    public List<HealthPotion> Potions { get; }
    public Trap Trap { get; private set; }
    
    private static readonly string[] roomDescriptions = {
        "A dimly lit chamber with ancient stone walls covered in mysterious runes.",
        "A spacious hall with broken pillars and cobwebs in every corner.",
        "A damp cave with glowing mushrooms providing an eerie light.",
        "An old library with scattered books and torn scrolls.",
        "A forgotten throne room with a deteriorating royal chair.",
        "A musty storage room filled with broken barrels and crates.",
        "An old armory with rusty weapons hanging on the walls.",
        "A chapel with shattered stained glass windows.",
        "A kitchen with rotting wooden tables and rusty utensils.",
        "A guard room with old armor stands and weapon racks."
    };

    public Room() {
        Random rand = new Random();
        Description = roomDescriptions[rand.Next(roomDescriptions.Length)];
        Enemies = new List<Goblin>();
        Potions = new List<HealthPotion>();

        int roomType = rand.Next(3);
        switch (roomType) {
        case 0:
            int enemyCount = rand.Next(1, 3);
            for (int i = 0; i < enemyCount; i++) {
                Enemies.Add(new Goblin());
            }

            if (rand.Next(2) == 0) {
                Potions.Add(new HealthPotion());
            }

            break;

        case 1:
            Potions.Add(new HealthPotion());
            break;

        case 2:
            Trap = new Trap();
            if (rand.Next(2) == 0) {
                Potions.Add(new HealthPotion());
            }

            break;
        }
    }
}