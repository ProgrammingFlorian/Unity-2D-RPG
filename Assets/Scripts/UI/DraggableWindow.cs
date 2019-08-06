using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableWindow : MonoBehaviour, IBeginDragHandler, IDragHandler {

    public RectTransform window;
    public RectTransform screen;

    public Vector2 borderMin = new Vector2(50, 50);
    public Vector2 borderMax = new Vector2(50, 100);

    private Vector2 offset;

    public void OnBeginDrag(PointerEventData eventData) {
        offset = eventData.position - (Vector2) window.position;
        window.position = eventData.position - offset;
    }

    public void OnDrag(PointerEventData eventData) {
        Vector2 pos = eventData.position - offset;
        if (pos.x - window.sizeDelta.x < borderMin.x) {
            pos.x = borderMin.x + window.sizeDelta.x;
        } else if (pos.x + window.sizeDelta.x > screen.rect.width * screen.localScale.x - borderMax.x) {
            pos.x = screen.rect.width * screen.localScale.x - borderMax.x - window.sizeDelta.x;
        }
        if (pos.y - window.sizeDelta.y < borderMin.y) {
            pos.y = borderMin.y + window.sizeDelta.y;
        } else if (pos.y + window.sizeDelta.y > screen.rect.height * screen.localScale.y - borderMax.y) {
            pos.y = screen.rect.height * screen.localScale.y - borderMax.y - window.sizeDelta.y;
        }
        window.position = pos;
    }
}
