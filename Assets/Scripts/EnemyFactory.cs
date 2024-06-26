using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ������ �ð��� �� ������ Enemy�� �����Ѵ�.
    // ���� �ð�, Enemy ������, ����� �ð�
    public GameObject enemyPrefab;
    public float delayTime = 3.0f;
    float currentTime = 0;
    float printTime = 1.0f;
    int timeCount = 3;
    bool isTimerStart = true;

    void Start()
    {

    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > delayTime)
        {
            // Enemy�� �����Ѵ�.
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;
            print("����");

            // ��� �ð��� �ٽ� 0���� �ʱ�ȭ�Ѵ�.
            currentTime = 0;
        }

        #region 3�� ī��Ʈ ��� ���� ����
        // 3�ʺ��� ī��Ʈ �ٿ��� �����Ѵ�. 
        // ��, �� 1�ʸ��� ���� �ð��� ����Ѵ�. 
        // ���������� "Start"�� ����Ѵ�.
        // ���� �ð��� 0�ʰ� �Ǹ� ī��Ʈ�� �ߴ��Ѵ�.
        // if (isTimerStart)
        // {
        //    printTime = 3;
        //    StartTimer();
        // }
        #endregion
    }

    void StartTimer()
    {
        currentTime += Time.deltaTime;
        if (currentTime > printTime)
        {
            if (timeCount == 0)
            {
                print("����");
                isTimerStart = false;
                // currentTime = 0;
                // printTime = 3;
            }
            else
            {
                print(timeCount);
            }
            timeCount--;
            currentTime = 0;
        }
    }
}
