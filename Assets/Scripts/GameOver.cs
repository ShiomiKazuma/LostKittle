using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool firstPush_retry = false;
    private bool firstPush_exit = false;
    public void Retry()
    {
        if (!firstPush_retry)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene(StartLostKattle.sceen_name);
            firstPush_retry = true;
            Debug.Log("���g���C���܂���");
        }

    }

    public void Finish()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
