using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾ ���ϴ� �������� �̵��Ѵ�.
    // ����, �ӷ� = �ӵ� (Vector)

    public float moveSpeed = 0.1f;
    public Vector3 direction;

    // ó�� �����Ǿ��� �� �� ���� ����Ǵ� �Լ�
    void Start()
    {
        // transform.position += Vector3.right;
    }

    // �� �����Ӹ��� �ݺ��ؼ� �����ϴ� �Լ�
    void Update()
    {
        // �̵� ����: p = p0 + vt


        // Vector3 direction =  new Vector3(1, 1, 0);
        // transform.position += Vector3.right * moveSpeed;
        // transform.position += direction * moveSpeed;

        // print(transform.position);

        // ������� �Է� �ޱ�
        float h = Input.GetAxis("Horizontal");
        print(h);
    }
}
