using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(CanvasGroup))]
public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public enum SlotType {
        All, Armor, Weapons,
        FirstHand, SecondHand, Helmet, Chest, Leg, Feet
    }

    public Item item;
    public int amount = 0;
    public SlotType type = SlotType.All;

    public Image imageComponent;
    public Text amountText;

    private CanvasGroup canvasGroup;

    private Transform originalParent;
    private Vector2 offset;

    private bool isDragging = false;

    private void Start() {
        canvasGroup = GetComponent<CanvasGroup>();
        originalParent = transform.parent;
        UpdateItem();
    }

    public void UpdateItem() {
        if (item != null) {
            imageComponent.color = Color.white;
            imageComponent.gameObject.name = item.name;
            imageComponent.sprite = item.sprite;
        } else {
            imageComponent.color = new Color(1, 1, 1, 0);
        }
        if (item != null && item.stackable) {
            amountText.text = amount.ToString();
        } else {
            amountText.text = "";
        }
    }

    public void IncreaseAmount() {
        amount++;
        amountText.text = amount.ToString();
    }

    public bool SetItem(Item item) {
        return SetItem(item, 1);
    }

    public bool SetItem(Item item, int amount) {
        if (CanHoldItem(item)) {
            this.item = item;
            this.amount = amount;
            UpdateItem();
            return true;
        } else {
            return false;
        }
    }

    public void Remove() {
        amount = 0;
        item = null;
        UpdateItem();
    }

    public bool CanHoldItem(Item item) {
        if (item == null) {
            return true;
        }
        switch (type) {
            case SlotType.All:
                return true;
            case SlotType.Armor:
                return item.type == Item.ItemType.Helmet || item.type == Item.ItemType.Chest || item.type == Item.ItemType.Leg || item.type == Item.ItemType.Feet;
            case SlotType.Weapons:
                return item.type == Item.ItemType.Weapon;
            case SlotType.FirstHand:
                return item.type == Item.ItemType.Weapon || item.type == Item.ItemType.Attack;
            case SlotType.SecondHand:
                return true;
            case SlotType.Helmet:
                return item.type == Item.ItemType.Helmet;
            case SlotType.Chest:
                return item.type == Item.ItemType.Chest;
            case SlotType.Leg:
                return item.type == Item.ItemType.Leg;
            case SlotType.Feet:
                return item.type == Item.ItemType.Feet;
        }
        return false;
    }

    public void OnBeginDrag(PointerEventData eventData) {
        if (item != null && Context.GetUiManager().CanStartDrag()) {
            isDragging = true;
            offset = eventData.position - (Vector2) transform.position;
            transform.SetParent(Context.GetCanvas());
            transform.position = eventData.position - offset;
            canvasGroup.blocksRaycasts = false;
        }
    }

    public void OnDrag(PointerEventData eventData) {
        if (isDragging) {
            transform.position = eventData.position - offset;
        }
    }

    public void OnEndDrag(PointerEventData eventData) {
        if (isDragging) {
            isDragging = false;
            transform.SetParent(originalParent);
            transform.localPosition = Vector2.zero;
            canvasGroup.blocksRaycasts = true;
        }
    }

    public void OnDrop(PointerEventData eventData) {
        if (Context.GetUiManager().CanStartDrag()) {
            ItemData droppedItem = eventData.pointerDrag.GetComponent<ItemData>();

            Item newItem = droppedItem.item;
            int newAmount = droppedItem.amount;

            if (newItem != item) {
                if (CanHoldItem(newItem)) {
                    if (droppedItem.CanHoldItem(item)) {
                        droppedItem.SetItem(item, amount);
                    } else {
                        droppedItem.SetItem(null);
                        Context.GetInventory().AddItemToBackpack(item, amount);
                    }
                    SetItem(newItem, newAmount);
                }
            } else if (item.stackable) {
                droppedItem.SetItem(null);
                amount += newAmount;
            }
            UpdateItem();
        }
    }

    public void OnPointerEnter(PointerEventData eventData) {
        if (item != null && (Context.GetUiManager().InventoryIsActive || Context.GetUiManager().StatWindowIsActive)) {
            Context.GetInventory().tooltip.Activate(item);
        }
    }

    public void OnPointerExit(PointerEventData eventData) {
        if (item != null) {
            Context.GetInventory().tooltip.Deactivate();
        }
    }
}
