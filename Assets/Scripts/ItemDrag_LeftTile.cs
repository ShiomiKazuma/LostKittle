using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ItemDrag_LeftTile : MonoBehaviour, IDragHandler, IDropHandler
{
    [SerializeField] public GameObject prehab;
    private Vector3 res_posw = Vector3.zero;
    private RectTransform ui_pos;
    GameManager game_manager;

    void Start()
    {
        ui_pos = GetComponent<RectTransform>();
        res_posw = gameObject.transform.position;

        game_manager = GameObject.Find("GameManager").GetComponent<GameManager>();
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

        //初期位置に戻す
        //RectTransform rectTransform = GetComponent<RectTransform>();
        ui_pos.position = res_posw;

        if(prehab.name == "Police")
        {
            game_manager.ScoreDownPolice();
        }
        else
        {
            game_manager.ScoreDownTile();
        }
        
    }

}

