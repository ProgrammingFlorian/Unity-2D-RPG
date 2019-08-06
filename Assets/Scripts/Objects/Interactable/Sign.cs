public class Sign : Interactable {

    public Dialogues dialogue;
    private bool readsSign = false;

    private Sign() {
        contextClueType = ContextClueType.Self;
    }

    protected override void OnInteraction() {
        if (!readsSign) {
            Context.GetDialogueManager().StartDialogue(dialogue, "text", OnTrigger);
            readsSign = true;
        } else {
            Context.GetDialogueManager().StopDialogue();
            readsSign = false;
        }
        ShowContextClue(!readsSign);
    }

    protected override void OnLeave() {
        if (readsSign) {
            Context.GetDialogueManager().StopDialogue();
            ShowContextClue(true);
            readsSign = false;
        }
    }

    private void OnTrigger(string trigger) {
        if (trigger == "end") {
            readsSign = false;
            ShowContextClue(true);
        }
    }

}
