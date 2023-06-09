using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // �@変数の定義（データを入れるための箱を作る）
    [SerializeField] public GameObject target;
    private Vector3 offset;

    void Start()
    {
        // �A代入（作成した箱の中にデータを入れる）
        offset = transform.position - target.transform.position;
    }

    void Update()
    {
        // �B活用（データの入った箱を活用する）
        transform.position = target.transform.position + offset;
    }
}
