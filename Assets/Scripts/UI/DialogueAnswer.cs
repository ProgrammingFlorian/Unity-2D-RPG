using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueAnswer : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public int index;

    public void OnPointerClick(PointerEventData eventData) {
        Context.GetDialogueManager().ChooseAnswer(index);
    }

    public void OnPointerEnter(PointerEventData eventData) {
        Context.GetDialogueManager().SelectAnswer(index);
    }
}
