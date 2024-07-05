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
    // public GameObject explosionPrefab;

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
            // ����, �÷��̾ �ִٸ�...
            if (player != null)
            {
                // �÷��̾ ���� ����
                dir = player.transform.position - transform.position;
                dir.Normalize();

                // ���� ���� ������ �÷��̾ ���� �������� �����Ѵ�.
                // 1. transform ������ ������ Ȱ���� ���
                // transform.up = dir * -1;
                // 2. Quaternion Ŭ������ �Լ��� �̿��ؼ� ������ ����ϴ� ���
                Quaternion rot = Quaternion.LookRotation(dir, transform.up);
                transform.rotation = rot;
            }
            else
            {
                dir = Vector3.down;
            }
        }

        // print("���� ��: " + GameManager.gm.BestScore);
    }

    void Update()
    {
        // �Ʒ� ���� (���� ��ǥ)
        // Vector3 dir = new Vector3(0, -1, 0);

        // p = p0 + vt
        transform.position += dir * enemySpeed * Time.deltaTime;

        // transform.Translate(dir * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ����� �÷��̾���...
        if (other.gameObject.name == "Player")
        {
            // �÷��̾ �����ϰ�
            Destroy(other.gameObject);

            // �ְ� ������ �����Ѵ�.
            PlayerPrefs.SetInt("BestScore", GameManager.gm.BestScore);

            // ���� ���� UI�� Ȱ��ȭ�Ѵ�.
            GameManager.gm.showGameOverUI();
        }
        // ���� �����Ѵ�.
        Destroy(gameObject);
    }

    // �����Ǵ� ������ ȣ��Ǵ� �̺�Ʈ �Լ�
    // private void OnDestroy()
    // {
    //    // ���� ȿ�� ������Ʈ�� ���� ��ġ�� �����Ѵ�.
    //    GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
    //    ParticleSystem fx = explosion.GetComponent<ParticleSystem>();
    //    fx.Play();
    // }
}
