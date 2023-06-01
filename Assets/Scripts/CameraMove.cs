using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // �@�ϐ��̒�`�i�f�[�^�����邽�߂̔������j
    [SerializeField] public GameObject target;
    private Vector3 offset;

    void Start()
    {
        // �A����i�쐬�������̒��Ƀf�[�^������j
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        // �B���p�i�f�[�^�̓������������p����j
        transform.position = target.transform.position + offset;
    }
}
