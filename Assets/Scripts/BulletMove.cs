using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // 사용자가 마우스 왼쪽 버튼을 누르면 총알이 총구에 생성되게 하고 싶다.
    // 1. 사용자가 마우스 왼쪽 버튼을 누르는지 확인한다.
    // 2. 총알을 생성한다.
    // 3. 생성된 총알을 총구로 옮긴다.

    public float bulletSpeed = 10;
    public GameObject player;
    public float lifeSpan = 5.0f;
    float currentTime = 0;


    void Start()
    {
        
    }

    void Update()
    {
        // 위로 계속 이동하고 싶다.
        // 방향: 위로, 이동 속력: float, public
        // 이동 공식: p = p0 + vt , p += vt
        // 월드 방향
        Vector3 worldDir = Vector3.up;

        // 로컬 방향 (나를 기준)
        Vector3 localDir = transform.up;

        transform.position += localDir * bulletSpeed * Time.deltaTime;
        // transform.position += new Vector3(0, 1, 0) * bulletSpeed * Time.deltaTime;
        

        currentTime += Time.deltaTime;
        // 만약 게임 오브젝트가 5초 이상 남아 있다면
        if(currentTime > lifeSpan)
        {
            // 게임 오브젝트를 제거한다.
            Destroy(gameObject);
        }
    }

    // 물리적 충돌이 발생했을 때 실행되는 이벤트 함수

    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 게임 오브젝트를 제거한다.
        Destroy(collision.gameObject);

        // 나를 제거한다.
        Destroy(gameObject);
    }

    // 물리적 충돌 없이 충돌 감지만 했을 때 실행되는 이벤트 함수
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 게임 오브젝트를 제거한다.
        EnemyMove enemy = other.gameObject.GetComponent<EnemyMove>();
        
        // enemy 변수에 값이 있다면...
        if(enemy != null)
        {
            Destroy(other.gameObject);

            // 플레이어 게임 오브젝트에 붙어있는 PlayerFire 컴포넌트를 가져온다.
            PlayerFire playerFire = player.GetComponent<PlayerFire>();

            // PlayerFire 컴포넌트에 있는 PlayExplosionSound 함수를 실행한다.
            playerFire.PlayExPlosionSound();
        }

        // 나를 제거한다.
        Destroy(gameObject);
    }
}
