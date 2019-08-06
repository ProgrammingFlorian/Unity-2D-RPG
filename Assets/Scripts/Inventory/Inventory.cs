using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum InventorySlot {
        Holding, Feet, Legs, Chest, Helmet, Hand
    }

    [Header("Items")]
    public Item testItem_stackable;
    public Item testItem_not;

    [Header("Panel")]
    public GameObject inventoryPanel;
    public GameObject barPanel;
    public Tooltip tooltip;

    [Header("ItemData")]
    public ItemData[] slots;
    public ItemData slotHolding;
    public ItemData slotFeet;
    public ItemData slotLegs;
    public ItemData slotChest;
    public ItemData slotHelmet;
    public ItemData slotHand;
    public GameObject slotPrefab;

    private Dictionary<InventorySlot, ItemData> slotSlots = new Dictionary<InventorySlot, ItemData>();

    private PlayerController player;
    private UIManager uiManager;

    private void Start() {
        player = Context.GetPlayer();
        uiManager = Context.GetUiManager();

        slotSlots.Add(InventorySlot.Holding, slotHolding);
        slotSlots.Add(InventorySlot.Feet,    slotFeet);
        slotSlots.Add(InventorySlot.Legs,    slotLegs);
        slotSlots.Add(InventorySlot.Chest,   slotChest);
        slotSlots.Add(InventorySlot.Helmet,  slotHelmet);
        slotSlots.Add(InventorySlot.Hand,    slotHand);

        AddItemToBackpack(testItem_stackable);
        AddItemToBackpack(testItem_stackable);
        AddItemToBackpack(testItem_stackable);
        AddItemToSlot(testItem_not, InventorySlot.Hand);

        slots[5].SetItem(testItem_stackable);
        slots[6].SetItem(testItem_not);

        Context.controls.GUI.Inventory.performed += _ => {
            ToggleInventory();
        };

        Context.controls.Inventory.Item1.performed += _ => {
            UseItem(1);
        };
        Context.controls.Inventory.Item2.performed += _ => {
            UseItem(2);
        };
        Context.controls.Inventory.Item3.performed += _ => {
            UseItem(3);
        };
        Context.controls.Inventory.Item4.performed += _ => {
            UseItem(4);
        };
        Context.controls.Inventory.Item5.performed += _ => {
            UseItem(5);
        };
        Context.controls.Inventory.Item6.performed += _ => {
            UseItem(6);
        };
        Context.controls.Inventory.Item7.performed += _ => {
            UseItem(7);
        };
        Context.controls.Inventory.Item8.performed += _ => {
            UseItem(8);
        };
        Context.controls.Inventory.Item9.performed += _ => {
            UseItem(9);
        };
        Context.controls.Inventory.Item10.performed += _ => {
            UseItem(10);
        };
    }

    public void AddItemToSlot(Item item, InventorySlot slot) {
        if (CanAddItem(slot)) {
            if (slotSlots[slot].item == null) {
                slotSlots[slot].SetItem(item);
                if (slot == InventorySlot.Holding) {
                    player.HoldItem(item.sprite);
                }
            } else if (item.stackable && slotSlots[slot].item == item) {
                slotSlots[slot].GetComponentInChildren<ItemData>().amount++;
            } else {
                AddItemToBackpack(item);
            }
        }
    }

    public void AddItemToBackpack(Item item) {
        if (BackpackHasSpace()) {
            if (item.stackable) {
                for (int i = 0; i < slots.Length; i++) {
                    if (slots[i].item == item) {
                        slots[i].IncreaseAmount();
                        return;
                    }
                }
            }
            for (int i = 0; i < slots.Length; i++) {
                if (slots[i].item == null) {
                    slots[i].SetItem(item);
                    break;
                }
            }
        }
    }

    public void AddItemToBackpack(Item item, int amount) {
        for (int i = 0; i < amount; i++) {
            AddItemToBackpack(item);
        }
    }

    public bool CanAddItem(InventorySlot slot) {
        return slotSlots[slot].item == null || BackpackHasSpace();
    }

    public bool BackpackHasSpace() {
        for (int i = 0; i < slots.Length; i++) {
            if (slots[i].item == null) {
                return true;
            }
        }
        return false;
    }

    /*
     * Returns false if the item was not found
     */
    public bool RemoveItem(Item item) {
        bool found = false;
        foreach (KeyValuePair<InventorySlot, ItemData> i in slotSlots) {
            if (i.Value.item == item) {
                slotSlots[i.Key].Remove();
                found = true;
            }
        }
        if (!found) {
            for (int i = 0; i < slots.Length; i++) {
                if (slots[i].item == item) {
                    slots[i].Remove();
                    found = true;
                }
            }
        }
        return found;
    }

    public bool HasItem(Item item) {
        foreach (ItemData i in slots) {
            if (i.item == item) {
                return true;
            }
        }
        return false;
    }

    public bool HasAnyKey() {
        foreach (ItemData i in slots) {
            if (i.item.type == Item.ItemType.Key) {
                return true;
            }
        }
        return false;
    }

    public void StopHolding() {
        if (slotSlots[InventorySlot.Holding].item != null) {
            AddItemToBackpack(slotSlots[InventorySlot.Holding].item);
            slotSlots[InventorySlot.Holding].item = null;
            player.StopHolding();
        }
    }

    public void UseItem(int index) {
        index = Mathf.Clamp(index, 1, 10) - 1;
        slots[index].item.Use();
    }

    /*
     * Window
     */

    public bool ToggleInventory() {
        if (uiManager.InventoryIsActive) {
            Hide();
        } else {
            Show();
        }
        return uiManager.InventoryIsActive;
    }

    public void Show() {
        if (uiManager.CanOpenWindow()) {
            inventoryPanel.SetActive(true);
            uiManager.InventoryIsActive = true;
        }
    }

    public void Hide() {
        inventoryPanel.SetActive(false);
        uiManager.InventoryIsActive = false;
        tooltip.Deactivate();
    }

    public void ShowBar() {
        barPanel.SetActive(true);
    }

    public void HideBar() {
        barPanel.SetActive(false);
    }

}
