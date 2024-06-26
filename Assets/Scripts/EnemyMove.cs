using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // ������ Ȯ���� ���� �Ʒ��� �Ǵ� �÷��̾� �������� �̵� ������ �����Ѵ�.
    // Ȯ���� ���� ��÷�Ѵ�. -> Ȯ�� ����, ���� ��

    // �ʿ� ���: ����, �ӷ�(ũ��)
    public float enemySpeed = 10;
    public GameObject player;
    public int downRate = 35;

    Vector3 dir;

    void Start()
    {
        // 1. ���� ������ "Player"��� �̸����� ���� ������Ʈ�� ã�´�.
        // player = GameObject.Find("Player");

        // 2. ���� ������ PlayerMove ������Ʈ�� ������ �ִ� ������Ʈ�� ã�´�.
        // PlayerMove playerComp = FindObjectOfType<PlayerMove>();
        // player = playerComp.gameObject;

        // 3. ���� ������Ʈ�� ������ �±� �̸����� ���� ������Ʈ�� ã�´�.
        player = GameObject.FindGameObjectWithTag("MyPlayer");



        // ������ ���ڸ� �ϳ� �̴´�.
        int myNumber = Random.Range(0, 100);

        // ����, ���� ���ڰ� downRate���� ������, ������ �Ʒ��� �����Ѵ�.
        if (myNumber < downRate)
        {
            dir = Vector3.down;
        }

        // �׷��� �ʴٸ�, ������ �÷��̾� ������ �����Ѵ�.
        else
        {
            // �÷��̾ ���� ����
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
    }

    void Update()
    {
        // �Ʒ� ���� (���� ��ǥ)
        // Vector3 dir = new Vector3(0, -1, 0);

        // p = p0 + vt
        transform.position += dir * enemySpeed * Time.deltaTime;
    }
}
