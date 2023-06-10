using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int player_hp = 1;
    [SerializeField] GameObject canvas;
    string scean_name;
    GameObject stage_name;
    GameObject time;
    private float timer;

    private void Start()
    {
        stage_name = GameObject.Find("StageName");
        time = GameObject.Find ("Time");
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        Text stage_name_text = stage_name.GetComponent<Text>();
        stage_name_text.text = SceneManager.GetActiveScene().name;

        Text time_text = time.GetComponent<Text>();
        timer += Time.deltaTime;
        time_text.text = timer.ToString("f2");

        if (Input.GetButtonDown("Reset")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void EnemyHit(int damage)
    {
        player_hp -= damage;

        if(player_hp <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("GameOver");
        }
    }

      
}
