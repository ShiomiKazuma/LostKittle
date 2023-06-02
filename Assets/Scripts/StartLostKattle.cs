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
    string before;
    // Start is called before the first frame update
    void Start()
    {
        before = "forward";
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
                switch(before)
                {
                    case "forward":
                        this.gameObject.transform.position = new Vector3(pos.x, pos.y + move, pos.z);
                        break;

                    case "right":
                        this.gameObject.transform.position = new Vector3(pos.x + move, pos.y, pos.z);
                        break;

                    case "left":
                        this.gameObject.transform.position = new Vector3(pos.x - move, pos.y, pos.z);
                        break;

                    case "down":
                        this.gameObject.transform.position = new Vector3(pos.x, pos.y - move, pos.z);
                        break;
                }
                break;


            case "right":
                switch (before)
                {
                    case "forward":
                        this.gameObject.transform.position = new Vector3(pos.x, pos.y + move, pos.z);
                        break;

                    case "right":
                        this.gameObject.transform.position = new Vector3(pos.x + move, pos.y, pos.z);
                        break;

                    case "left":
                        this.gameObject.transform.position = new Vector3(pos.x - move, pos.y, pos.z);
                        break;

                    case "down":
                        this.gameObject.transform.position = new Vector3(pos.x, pos.y - move, pos.z);
                        break;
                }
                break;
        }


        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //ç∂Ç…ã»Ç™ÇÈ
        if (collision.gameObject.tag == "Left tile")
        {
            tile = "left";

            switch(before)
            {
                case "forward":
                    before = "left";
                    break;

                case "right":
                    before = "forward";
                    break;

                case "left":
                    before = "down";
                    break;

                case "down":
                    before = "right";
                    break;


            }
        }

        //âEÇ…ã»Ç™ÇÈ
        if (collision.gameObject.tag == "Right tile")
        {
            tile = "left";

            switch (before)
            {
                case "forward":
                    before = "right";
                    break;

                case "right":
                    before = "down";
                    break;

                case "left":
                    before = "forward";
                    break;

                case "down":
                    before = "left";
                    break;


            }
        }
    }
}
