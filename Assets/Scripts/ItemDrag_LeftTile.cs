using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDrag_LeftTile : MonoBehaviour, IDragHandler, IDropHandler
{
    [SerializeField] private GameObject prehab;
    private Vector3 res_posw = Vector3.zero;
    private RectTransform ui_pos;

    void Start()
    {
        ui_pos = GetComponent<RectTransform>();
        res_posw = gameObject.transform.position;
    }

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
        Instantiate(prehab,target,transform.rotation);

        //�����ʒu�ɖ߂�
        //RectTransform rectTransform = GetComponent<RectTransform>();
        ui_pos.position = res_posw;

    }

}

