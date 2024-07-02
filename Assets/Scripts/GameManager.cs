using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singletone Pattern class
    // static ����
    public static GameManager gm;

    public ScoreUI scoreUI;

    int currentScore;

    public int BestScore { get { return bestScore; } }
    int bestScore;

    void Awake()
    {
        // ���� �� �� ���� �����ϵ��� ó��
        if(gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // ���� ǥ�� �ʱ�ȭ
        AddScore(0);

        // �ְ� ���� ǥ��
        // ����, "BestScore"��� Ű�� ����� �����Ͱ� �ִٸ�...
        // print(PlayerPrefs.HasKey("BestScore"));
        if (PlayerPrefs.HasKey("BestScore"))
        {
            // "BestScore"��� Ű�� ����� �����͸� �ҷ��´�.
            bestScore = PlayerPrefs.GetInt("BestScore");           
            scoreUI.text_bestScore.text = bestScore.ToString();
        }
        else
        {
            scoreUI.text_bestScore.text = "0";
        }

    }

    // ������ �߰��ϰ�, ����� ������ UI�� ����Ѵ�.
    public void AddScore(int point)
    {
        // 1. ������ �����Ѵ�.
        currentScore += point;

        // 2. ���� ������ UI�� ����Ѵ�.
        scoreUI.text_currentScore.text = currentScore.ToString();

        // 3. ����, ���� ������ �ְ� �������� �� ���ٸ�...
        if (currentScore > bestScore)
        {
            // 3-1. ���� ������ �ְ� ������ �����Ѵ�.
            bestScore = currentScore;

            // 3-2. ����� �ְ� ������ UI�� ����Ѵ�.
            scoreUI.text_bestScore.text = bestScore.ToString();
        }
    }
}
