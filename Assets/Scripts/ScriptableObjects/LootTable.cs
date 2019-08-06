using UnityEngine;

[System.Serializable]
public class Loot {
    public GameObject loot;
    public int chance;
}

[CreateAssetMenu]
public class LootTable : ScriptableObject
{
    public Loot[] loot;

    public GameObject GetLoot() {
        int cumulativeProb = 0;
        int currentProb = Random.Range(0, 100);
        for (int i = 0; i < loot.Length; i++) {
            cumulativeProb += loot[i].chance;
            if (currentProb <= cumulativeProb) {
                return loot[i].loot;
            }
        }
        return null;
    }
}
