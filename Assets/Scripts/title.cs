using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    private bool firstPush_start = false;
    private bool firstPush_exit = false;
    //start�{�^���������ꂽ���̏���
    public void PressStart()
    {
        Debug.Log("�X�^�[�g�{�^����������܂���");

        if (!firstPush_start)
        {

            //���̃V�[���ɍs������
            SceneManager.LoadScene("stage1");
            firstPush_start = true;
        }
    }

    //exit�{�^���������ꂽ���̏���
    public void PressExit()
    {
        Debug.Log("exit�{�^����������܂���");
        if (!firstPush_exit)
        {
            Debug.Log("�Q�[�����I�����܂���");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
                Application.Quit();//�Q�[���v���C�I��
#endif
            firstPush_exit = true;
        }
    }
}
