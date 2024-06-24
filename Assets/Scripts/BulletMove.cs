using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed = 0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        // ���� ��� �̵��ϰ� �ʹ�.
        // ����: ����, �̵� �ӷ�: float, public
        // �̵� ����: p = p0 + vt , p += vt
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;
        // transform.position += new Vector3(0, 1, 0) * bulletSpeed * Time.deltaTime;
    }
}
