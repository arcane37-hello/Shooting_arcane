using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // �Ʒ� �������� ��� �̵��ϰ� �ʹ�.
    public float enemySpeed = 10;
    public GameObject player;

    Vector3 dir;

    void Start()
    {
        // �÷��̾ ���� ����
        dir = player.transform.position - transform.position;
        dir.Normalize();
    }

    void Update()
    {
        // �Ʒ� ���� (���� ��ǥ)
        // Vector3 dir = new Vector3(0, -1, 0);

        // p = p0 + vt
        transform.position += dir * enemySpeed * Time.deltaTime;
    }
}
