using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 아래 방향으로 계속 이동하고 싶다.
    public float enemySpeed = 10;
    public GameObject player;

    Vector3 dir;

    void Start()
    {
        // 플레이어를 향한 방향
        // dir = player.transform.position - transform.position;
        // dir.Normalize();
    }

    void Update()
    {
        // 아래 방향 (월드 좌표)
        // Vector3 dir = new Vector3(0, -1, 0);

        dir = player.transform.position - transform.position;
        dir.Normalize();

        // p = p0 + vt
        transform.position += dir * enemySpeed * Time.deltaTime;
    }
}
