using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    //Score��\������e�L�X�g
    private GameObject ScoreText;

    //Score�ϐ�
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

            this.gameoverText.GetComponent<Text>().text = "" + score;
    }

    void OnCollisionEnter(Collision other) 
    {
        //Tag (SmallStaeTag, �Ȃǁj
        Debug.Log("�Փ�:" + other.gameObject.tag);

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

