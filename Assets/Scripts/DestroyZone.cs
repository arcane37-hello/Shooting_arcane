using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // �ε��� ����� ��� �ı��Ѵ�. ��, �÷��̾�� �����Ѵ�.
        if (other.gameObject.tag != "Bullet")
        {
            Destroy(other.gameObject);
        }
    }
}
