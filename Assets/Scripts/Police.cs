using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    [SerializeField] GameObject enemy1;
    [SerializeField] public float move = 0.01f;
    string tile = "first";
    string before;
    // Start is called before the first frame update
    void Start()
    {
        tile = "forward";
        before = "right";
    }

    // Update is called once per frame
    void Update()
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
        //���ɋȂ���
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
        }

        //�E�ɋȂ���
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
        }

        //�ǂɓ����������̏���
        if (collision.gameObject.tag == "Wall")
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

        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}