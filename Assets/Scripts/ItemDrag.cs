using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDrag : MonoBehaviour
{
    [SerializeField] Camera _cam;
    private Vector3 offset;
    private void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMousePos();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMousePos() + offset;
    }
    private Vector3 GetMousePos()
    {
        return _cam.ScreenToWorldPoint(Input.mousePosition);
    }
}