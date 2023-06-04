using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int player_hp = 1;
    [SerializeField] GameObject canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyHit(int damage)
    {
        player_hp -= damage;

        if(player_hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
      
}
