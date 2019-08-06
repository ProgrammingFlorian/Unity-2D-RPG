using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject {

    public enum ItemType {
        Item, Key, Potion, Weapon, Feet, Leg, Chest, Helmet
    }

    public Sprite sprite;
    public string itemName;
    public string description;
    public ItemType type;
    public bool stackable;

    public virtual void Use() {

    }

}