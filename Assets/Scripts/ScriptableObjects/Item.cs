using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject {

    public enum ItemType {
        Item, Key, Potion, Weapon, Feet, Leg, Chest, Helmet, Attack
    }

    public Sprite sprite;
    public string itemName;
    public string description;
    public ItemType type;
    public bool stackable;

    [Header("Types of Items")]
    public Attack attackObj;

    public virtual void Use() {
        if (type == ItemType.Attack) {
            if (Context.GetPlayer().faceDir != Vector3.zero) {
                attackObj.Perform(Context.GetPlayer().transform.position, Context.GetPlayer().faceDir);
            }
        }
    }

}