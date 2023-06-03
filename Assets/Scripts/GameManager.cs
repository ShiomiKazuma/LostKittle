using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int player_hp = 1;
    private bool firstPush_retry = false;
    private bool firstPush_exit = false;
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

        if(player_hp == 0)
        {
           GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
        SceneManager.LoadScene("GameOver");
    }

    public void Retry()
    {
        if (!firstPush_retry)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            firstPush_retry = true;
        }

    }

    public void Finish()
    {
        if (!firstPush_exit)
        {
            Debug.Log("ゲームが終了しました");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
                Application.Quit();//ゲームプレイ終了
#endif
            firstPush_exit = true;
        }
    }
}
