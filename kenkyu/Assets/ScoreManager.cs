using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_object = null; // Textオブジェクト
    public GameObject Camera_object = null; // Cameraオブジェクト
    public float score_numX = 0; // スコア変数
    public float score_numY = 0; // スコア変数

    // 初期化
    void Start()
    {
    }

    // 更新
    void Update()
    {
        // オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Rotation X:" + score_numX + "\n" + "Rotation Y:" + score_numY;

        score_numX = Camera_object.GetComponent<Transform>().transform.localEulerAngles.x;
        score_numY = Camera_object.GetComponent<Transform>().transform.localEulerAngles.y;
    }
}