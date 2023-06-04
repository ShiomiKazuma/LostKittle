using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLostKattle : MonoBehaviour
{
    [SerializeField] GameObject LostKattle;
    [SerializeField] public float move = 0.01f;
    [SerializeField] int damage = 1;
    public static string sceen_name;
    string tile = "forward";
    string before;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        before = "forward";
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        sceen_name = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        switch (tile)
        {
            //case "first":
            //    this.gameObject.transform.position = new Vector3(pos.x, pos.y + move, pos.z);
            //    break;


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
        }

        //ìGÇ…è’ìÀÇµÇΩéûÇÃèàóù
        if (collision.gameObject.tag == "Enemy")
        {
            gameManager.EnemyHit(damage);
        }

        //ï«Ç…ìñÇΩÇ¡ÇΩéûÇÃèàóù
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
    }
 }

