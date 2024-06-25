using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tails : MonoBehaviour
{ 
    public float tailSpeed = 10;
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        
    }

    void Update()
    {
        // Ÿ���� �Ѿư��� �ʹ�.
        // 1. Ÿ��(Game Object)�� �����Ѵ�.
        // 2. Ÿ���� ���� ������ ����Ѵ�.
        dir = target.transform.position - transform.position;
        // dir.Normalize();

        // 3. ���� ����� ������ �ӷ����� �̵��Ѵ�.
        // p = p0 + vt
        transform.position += dir * tailSpeed * Time.deltaTime;
    }
}
