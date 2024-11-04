using P4_2_714230037.Characters;
using P4_2_714230037.Items;

namespace P4_2_714230037;

public class Game {
    private const int TOTAL_ROOMS = 5;
    private int _currentRoom = 1;
    private Character _player;
    private readonly List<HealthPotion> _playerPotions = new();

    private void SelectCharacter() {
        Console.WriteLine("Select your character:");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Archer");

        while (true) {
            string? choice = Console.ReadLine();
            switch (choice) {
            case "1":
                _player = new Warrior();
                return;
            case "2":
                _player = new Mage();
                return;
            case "3":
                _player = new Archer();
                return;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
            }
        }
    }


    public void Start() {
        Console.Clear();
        Console.WriteLine("Welcome to the Dungeon Adventure!");
        Console.WriteLine("Your goal is to explore the dungeon and survive.\n");
        SelectCharacter();

        while (_currentRoom <= TOTAL_ROOMS && _player.IsAlive()) {
            ExploreRoom();

            if (_player.IsAlive()) {
                Console.WriteLine("\nPress any key to continue to the next room...");
                Console.ReadKey();
                _currentRoom++;
            }
        }

        if (_player.IsAlive()) {
            Console.WriteLine("\nCongratulations! You've cleared the dungeon!");
        } else {
            Console.WriteLine("\nGame Over! The dungeon claims another victim!");
        }
    }

    private void ExploreRoom() {
        Console.Clear();
        Console.WriteLine($"===== Room {_currentRoom} of {TOTAL_ROOMS} =====");

        Room room = new Room();
        Console.WriteLine(room.Description);
        Console.WriteLine();
        Thread.Sleep(1500);

        if (room.Trap != null) {
            room.Trap.Trigger(_player);
            if (!_player.IsAlive()) return;
        }

        foreach (HealthPotion potion in room.Potions) {
            Console.WriteLine("You found a health potion!");
            _playerPotions.Add(potion);
        }

        if (room.Enemies.Count > 0) {
            Console.WriteLine($"{room.Enemies.Count} Goblin(s) appear! Prepare for battle!");
            Thread.Sleep(3000);
            if (!HandleCombat(room.Enemies)) return;
        } else if (room.Trap == null && room.Potions.Count == 0) {
            Console.WriteLine("The room appears to be empty and safe.");
        }
    }

    private bool HandleCombat(List<Goblin> enemies) {
        while (enemies.Count > 0 && _player.IsAlive()) {
            Console.Clear();
            Console.WriteLine("\n" + _player.GetStats());
            Console.WriteLine($"Potions: {_playerPotions.Count}");
            Console.WriteLine($"Enemies: {enemies.Count}");

            // Player turn
            if (!_player.IsStunned()) {
                Console.WriteLine("\nYour turn:");
                Console.WriteLine("1. Attack");
                if (_player.CanUseSpecial()) {
                    Console.WriteLine("2. Use Special Ability");
                }

                Console.WriteLine("3. Use Potion");

                string? choice = Console.ReadLine();
                Goblin target = enemies[0];

                switch (choice) {
                case "1":
                    _player.Attack(target);
                    break;
                case "2":
                    if (_player.CanUseSpecial()) {
                        _player.UseSpecialAbility(target);
                    } else {
                        Console.WriteLine("Special ability is on cooldown! Choose another action.");
                    }

                    break;
                case "3":
                    if (_playerPotions.Count > 0) {
                        _playerPotions[0].Use(_player);
                        _playerPotions.RemoveAt(0);
                    } else {
                        Console.WriteLine("No potions left!");
                    }

                    break;
                default:
                    Console.WriteLine("Invalid choice. Skipping turn.");
                    break;
                }
            } else {
                Console.WriteLine($"\n{_player.Name} is stunned and cannot act this turn!");
            }

            // Remove defeated enemies
            enemies.RemoveAll(e => !e.IsAlive());

            // Enemy turns
            foreach (Goblin enemy in enemies.ToList()) {
                Thread.Sleep(1000);
                if (!enemy.IsStunned()) {
                    if (new Random().Next(4) == 0 && enemy.CanUseSpecial()) {
                        enemy.UseSpecialAbility(_player);
                    } else {
                        enemy.Attack(_player);
                    }
                } else {
                    Console.WriteLine($"{enemy.Name} is stunned and cannot act this turn!");
                }

                if (!_player.IsAlive()) {
                    return false;
                }
            }

            // Update stun durations and cooldowns
            _player.UpdateStun();
            _player.UpdateCooldown();
            foreach (Goblin enemy in enemies) {
                enemy.UpdateStun();
                enemy.UpdateCooldown();
            }
        }

        return true;
    }
}