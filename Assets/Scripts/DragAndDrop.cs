using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    public RectTransform rectTrans;
    private Canvas myCanvas;
    private CanvasGroup canvasGroup;
    private Vector2 startPos;

    private SlotScript slotScript;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        myCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        startPos = gameObject.transform.position;

        slotScript = GetComponent<SlotScript>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("BEGININ");
        canvasGroup.blocksRaycasts = false;
        SlotScript.dropped = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("DRAGGIN");
        rectTrans.anchoredPosition += eventData.delta / myCanvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("ENDIN");
        canvasGroup.blocksRaycasts = true;
        if(!SlotScript.dropped) {
            ResetPosition();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("CLICKD");
    }

    public void ResetPosition()
    {
        rectTrans.transform.position = startPos;
    }
}
