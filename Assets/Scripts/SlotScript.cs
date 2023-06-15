using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IDropHandler {

    public GameObject missile;
    public GameObject missileCollide;
    private Canvas canvas;

    public static bool dropped = false;

    private void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        dropped = true;

        Debug.Log("item dropped");

        if(eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            Destroy(eventData.pointerDrag);
            DataHandler.currentMissile = Instantiate(missile, gameObject.transform.position, gameObject.transform.rotation, canvas.transform);
            Instantiate(missileCollide, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
