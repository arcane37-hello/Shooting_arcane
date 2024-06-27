using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ� �ʹ�.
    // 1. ����ڰ� ���콺 ���� ��ư�� �������� Ȯ���Ѵ�.
    // 2. �Ѿ��� �����Ѵ�.
    // 3. ������ �Ѿ��� �ѱ��� �ű��.

    public float bulletSpeed = 10;
    public GameObject player;
    public float lifeSpan = 5.0f;
    float currentTime = 0;


    void Start()
    {
        
    }

    void Update()
    {
        // ���� ��� �̵��ϰ� �ʹ�.
        // ����: ����, �̵� �ӷ�: float, public
        // �̵� ����: p = p0 + vt , p += vt
        // ���� ����
        Vector3 worldDir = Vector3.up;

        // ���� ���� (���� ����)
        Vector3 localDir = transform.up;

        transform.position += localDir * bulletSpeed * Time.deltaTime;
        // transform.position += new Vector3(0, 1, 0) * bulletSpeed * Time.deltaTime;
        

        currentTime += Time.deltaTime;
        // ���� ���� ������Ʈ�� 5�� �̻� ���� �ִٸ�
        if(currentTime > lifeSpan)
        {
            // ���� ������Ʈ�� �����Ѵ�.
            Destroy(gameObject);
        }
    }

    // ������ �浹�� �߻����� �� ����Ǵ� �̺�Ʈ �Լ�

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ���� ������Ʈ�� �����Ѵ�.
        Destroy(collision.gameObject);

        // ���� �����Ѵ�.
        Destroy(gameObject);
    }

    // ������ �浹 ���� �浹 ������ ���� �� ����Ǵ� �̺�Ʈ �Լ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ���� ������Ʈ�� �����Ѵ�.
        EnemyMove enemy = other.gameObject.GetComponent<EnemyMove>();
        
        // enemy ������ ���� �ִٸ�...
        if(enemy != null)
        {
            Destroy(other.gameObject);

            // �÷��̾� ���� ������Ʈ�� �پ��ִ� PlayerFire ������Ʈ�� �����´�.
            PlayerFire playerFire = player.GetComponent<PlayerFire>();

            // PlayerFire ������Ʈ�� �ִ� PlayExplosionSound �Լ��� �����Ѵ�.
            playerFire.PlayExPlosionSound();
        }

        // ���� �����Ѵ�.
        Destroy(gameObject);
    }
}
