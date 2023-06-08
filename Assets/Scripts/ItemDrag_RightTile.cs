using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag_RightTile : MonoBehaviour, IDragHandler, IDropHandler
{
    [SerializeField] private GameObject prehab;
    [SerializeField] private RectTransform ui_pos;



    public void OnDrag(PointerEventData eventData)
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.position = Input.mousePosition;
    }

    public void OnDrop(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 0;
        Vector3 target = Camera.main.ScreenToWorldPoint(mousePosition);
        target.z = 0;
        Instantiate(prehab, target, transform.rotation);
    }



}
