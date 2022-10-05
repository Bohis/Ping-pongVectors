using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovingObjectMouse : MonoBehaviour, IDragHandler {
    public void OnDrag(PointerEventData eventData) {
        Vector3 point = Camera.main.ScreenToWorldPoint(eventData.position);
        point.z = 0;
        transform.position = point;
    }
}