using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePosition;
    // public GameObject[] firePositions;
    // public GameObject firePosition2;


    void Start()
    {
        
    }

    void Update()
    {
        // ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ� �ʹ�.
        // 1. ����ڰ� ���콺 ���� ��ư�� �������� Ȯ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            // 2. �Ѿ��� �����Ѵ�.
            GameObject go = Instantiate(bulletPrefab);

            // 3. ������ �Ѿ��� �ѱ��� �ű��.
            // 3-1. �ѱ��� ���� ������Ʈ ������ ���� �����ϴ� ���
            go.transform.position = firePosition.transform.position;
            go.transform.rotation = firePosition.transform.rotation;
            // 3-2. �÷��̾��� ��ġ���� ���� 1.5���� ������ �����ϴ� ���
            // Vector3 firePos = transform.position + new Vector3(0, 1.5f, 0);
            // go.transform.position = firePos;
        }

        // �� �� �̻� �Ѿ��� �߻��� ���
        // if (Input.GetMouseButtonDown(0))
        // {
        //    for (int i = 0; i < firePosition.Length; i++)
        //    {
        //        // 2. �Ѿ��� �����Ѵ�.
        //        GameObject go = Instantiate(bulletPrefab);

        //        // 3. ������ �Ѿ��� �ѱ��� �ű��.
        //        go.transform.position = firePositions[i].transform.position;
        //    }
        // }
        #region ������ ��ư
        // ����ڰ� ���콺 ������ ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ� �ʹ�.
        // 1. ����ڰ� ���콺 ������ ��ư�� �������� Ȯ���Ѵ�.
        // if (Input.GetMouseButtonDown(1))
        // {
        // 2. �Ѿ��� �����Ѵ�.
        //  GameObject go2 = Instantiate(bulletPrefab);

        // 3. ������ �Ѿ��� �ѱ��� �ű��.
        //  go2.transform.position = firePosition2.transform.position;
        #endregion
    }
}
