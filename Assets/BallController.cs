using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //Scoreを表示するテキスト
    private GameObject ScoreText;

    //Score変数
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        //シーン中のScoreTextオブジェクトを取得
        this.gameoverText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

            this.gameoverText.GetComponent<Text>().text = "" + score;
    }

    void OnCollisionEnter(Collision other) 
    {
        //Tag (SmallStaeTag, など）
        Debug.Log("衝突:" + other.gameObject.tag);

        if( other.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }

        else if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }

    }
}

