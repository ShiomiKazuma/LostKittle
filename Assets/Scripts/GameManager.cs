using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int player_hp = 1;
    [SerializeField] GameObject canvas;
    string scean_name;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Reset")) 
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
