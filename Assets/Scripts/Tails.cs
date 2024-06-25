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
        // 타켓을 쫓아가고 싶다.
        // 1. 타겟(Game Object)을 설정한다.
        // 2. 타겟을 향한 방향을 계산한다.
        dir = target.transform.position - transform.position;
        // dir.Normalize();

        // 3. 계산된 방향과 지정된 속력으로 이동한다.
        // p = p0 + vt
        transform.position += dir * tailSpeed * Time.deltaTime;
    }
}
