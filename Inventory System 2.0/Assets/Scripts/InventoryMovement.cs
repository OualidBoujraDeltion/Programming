﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryMovement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    #region Variables
    public Transform parentToReturnTo;
    #endregion

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("OnBeginDrag");

        parentToReturnTo = this.transform.parent;
        this.transform.SetParent( this.transform.parent.parent );
    }

    public void OnDrag(PointerEventData eventData) {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");

        this.transform.SetParent( parentToReturnTo );
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
