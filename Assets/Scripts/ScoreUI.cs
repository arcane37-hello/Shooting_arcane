using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Legacy Text Ŭ���� ��� ��
using TMPro;            // Text Mesh Pro Ŭ������ ��� ��

public class ScoreUI : MonoBehaviour
{
    public Text text_currentScore;
    public Text text_bestScore;
    public TMP_Text tmp_currentScore;

    void Start()
    {
        // ��Ʈ ����
        // text_bestScore.color = new Color(1, 1, 0, 0.5f);
        // ��Ʈ ũ��
        // text_bestScore.fontSize = 100;
    }

    void Update()
    {
        
    }
}
