using System;

public class EventManager {

    //Player Stats
    public Action onLevelUp;
    //Action<health, maxHealth>
    public Action<int, int> onHealthChanged;
    //Action<mana, maxMana>
    public Action<int, int> onManaChanged;

}
