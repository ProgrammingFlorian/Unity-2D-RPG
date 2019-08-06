using UnityEngine;

public class PlayerStats {
    public int Experience {
        get; private set;
    }
    public float ExperienceToLevelUp {
        get; private set;
    }
    public int Level {
        get; private set;
    }
    public int Strength {
        get; private set;
    }
    private int health;
    public int Health {
        get {
            return health;
        }
        set {
            health = Mathf.Clamp(value, 0, MaxHealth);
            events.onHealthChanged?.Invoke(health, MaxHealth);
        }
    }
    public int MaxHealth {
        get; private set;
    }
    private int mana;
    public int Mana {
        get {
            return mana;
        }
        set {
            events.onManaChanged?.Invoke(mana, MaxMana);
            mana = Mathf.Clamp(value, 0, MaxMana);
        }
    }
    public int MaxMana {
        get; private set;
    }

    private EventManager events;

    public PlayerStats(EventManager eventManager) {
        events = eventManager;

        Experience = 0;
        ExperienceToLevelUp = 10;
        Level = 1;
        Strength = 1;
        MaxHealth = 10;
        Health = 10;
        MaxMana = 50;
        Mana = 50;
    }

    public void AddExperience(int amount) {
        Experience += amount;
        if (Experience >= ExperienceToLevelUp) {
            Level++;
            ExperienceToLevelUp *= 1.2f;
            events.onLevelUp();
        }
    }

    public void Heal(int amount) {
        health += amount;
    }

}
