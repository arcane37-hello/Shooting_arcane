using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListText : MonoBehaviour
{
    public List<int> ages = new List<int>();
    void Start()
    {
        // 1. ����Ʈ�� ���� �ִ� ���
        // ages.Add(20);

        // int student2 = 18;
        // ages.Add(student2);

        // 2. ����Ʈ���� ���� ����� ���
        // 2-1. ����Ʈ �ȿ� �ִ� Ư�� ���� ����� ���
        // ages.Remove(18);

        // 2-2. ����Ʈ �ȿ� �ִ� Ư�� �ε����� ���� ����� ���
        // ages.RemoveAt(2);

        // 2-3. ����Ʈ�� ��� ������ �� �����ϴ� ��� (����Ʈ �ʱ�ȭ)
        // ages.Clear();

        // 3. ����Ʈ �ȿ� �� �߿��� Ư�� ���� �ִ��� Ȯ���ϴ� ���
        int check = 35;

        // for(int i = 0; i < ages.Count; i++)
        //{
        //    if (ages[i] == check)
        //    {
        //        print(i.ToString() + "�׷� ���� �־��");
        //    }
        // }

        if(ages.Contains(check))
        {
            print("�׷� ���� �־��");
        }


    }

    void Update()
    {
        
    }
}
