using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class StartLostKattle : MonoBehaviour
{
    [SerializeField] GameObject LostKattle;
    [SerializeField] public float move = 0.01f;
    string tile = "first";
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        switch(tile)
        {
            case "first":
                this.gameObject.transform.position = new Vector3(pos.x, pos.y + move, pos.z);
                break;


            case "left":
                this.gameObject.transform.position = new Vector3(pos.x - move, pos.y, pos.z);
                break;
        }


        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //ç∂Ç…
        if (collision.gameObject.name == "RotateLeftTile")
        {
            tile = "left";
        }
    }
}
