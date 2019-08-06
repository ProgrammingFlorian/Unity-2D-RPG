using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Chest : Interactable {

    public Item content;
    public Dialogues dialogue;
    public BoolValue isOpen;

    private Animator anim;

    private Chest() {
        contextClueType = ContextClueType.None;
    }

    protected override void Start() {
        base.Start();
        anim = GetComponent<Animator>();
        anim.SetBool(Constants.ANIM_CHEST_OPENED, isOpen.value);
    }

    protected override void OnInteraction() {
        if (isOpen.value == false) {
            Context.GetDialogueManager().StartDialogue(dialogue, "text", trigger => {
                if (trigger == "end") {
                    Context.GetInventory().StopHolding();
                }
            });
            if (content != null) {
                Context.GetInventory().AddItemToSlot(content, Inventory.InventorySlot.Holding);
            }
            anim.SetBool(Constants.ANIM_CHEST_OPENED, true);
            isOpen.value = true;
        } else {
            Context.GetDialogueManager().StopDialogue();
            Context.GetInventory().StopHolding();
        }
    }
}