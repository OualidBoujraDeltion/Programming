using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropArea : InventoryMovement, IPointerEnterHandler, IPointerExitHandler {

    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("OnPointerEnter");
    }

    public void OnDrag(PointerEventData eventData) {
        Debug.Log("OnDrag");

        InventoryMovement dragging = eventData.pointerDrag.GetComponent<InventoryMovement>();
        if (dragging != null) {
            dragging.parentToReturnTo = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("OnPointerExit");
    }
}
