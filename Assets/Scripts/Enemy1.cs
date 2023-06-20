using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.Tilemaps;
using static UnityEditor.PlayerSettings;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] GameObject enemy1;
    [SerializeField] public float move = 0.01f;
    string tile = "first";
    string before;
    int destory_point;
    // Start is called before the first frame update
    void Start()
    {
        tile = "forward";
        before = "right";
        destory_point = 0;

        
    }

    private void FixedUpdate()
    {
        Vector3 pos = this.gameObject.transform.position;
        switch (tile)
        {

            case "left":
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


            case "forward":
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

            case "down":
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

            switch (before)
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

            destory_point += 1;

            if (destory_point >= 3) 
            {
                Destroy(collision.gameObject);
                destory_point = 0;
            }
        }

        //âEÇ…ã»Ç™ÇÈ
        if (collision.gameObject.tag == "Right tile")
        {
            tile = "right";

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

            destory_point += 1;

            if (destory_point >= 3)
            {
                Destroy(collision.gameObject);
                destory_point = 0;
            }
        }

        //ï«Ç…ìñÇΩÇ¡ÇΩéûÇÃèàóù
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Enemy")
        {
            tile = "down";

            switch (before)
            {
                case "forward":
                    before = "down";
                    break;
                case "right":
                    before = "left";
                    break;
                case "left":
                    before = "right";
                    break;
                case "down":
                    before = "forward";
                    break;
            }
        }
    }

    
}
