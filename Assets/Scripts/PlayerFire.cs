using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePosition;
    // public GameObject[] firePositions;
    // public GameObject firePosition2;

    public AudioClip[] sounds;
    public List<GameObject> bullets = new List<GameObject>();
    public GameObject[] bulletArray;
    public int bulletCount = 10;
    public bool useObjectPool = false;
    public bool useArray = false;

    AudioSource audioSource;
    int bulletNumber = 0;

    void Start()
    {
        // AudioSource ������Ʈ�� �������� ���
        audioSource = transform.GetComponent<AudioSource>();


        if (useObjectPool)
        {
            // �Ѿ� 10���� �̸� ���� bullets ����Ʈ�� �߰��Ѵ�.
            for (int i = 0; i < bulletCount; i++)
            {
                GameObject go = Instantiate(bulletPrefab);
                bullets.Add(go);
                // ������ �Ѿ��� BulletMove ������Ʈ�� �ִ� Player ������ �ڱ� �ڽ��� �ִ´�.
                go.GetComponent<BulletMove>().player = gameObject;

                // ������ �Ѿ��� ��Ȱ��ȭ�Ѵ�.
                go.SetActive(false);

                // ������ �Ѿ��� �÷��̾��� �ڽ� ������Ʈ�� ����Ѵ�.
                go.transform.parent = transform;
            }
        }

        if(useArray)
        {
            // �迭 ������ ũ�⸦ ������ ������ Ȯ���Ѵ�.
            bulletArray = new GameObject[bulletCount];

            // �迭�� �� ��ȣ�� �Ѿ� �Τ����Ͻ��� �����ؼ� �Ҵ��Ѵ�.
            for(int i = 0; i < bulletCount; i++)
            {
                GameObject go = Instantiate(bulletPrefab);
                bulletArray[i] = go;
                go.SetActive(false);
                go.GetComponent<BulletMove>().player = gameObject;

                // ������ �Ѿ��� �÷��̾��� �ڽ� ������Ʈ�� ����Ѵ�.
                go.transform.parent = transform;
            }
        }

    }

    void Update()
    {
        // ����ڰ� ���콺 ���� ��ư�� ������ �Ѿ��� �ѱ��� �����ǰ� �ϰ� �ʹ�.
        // 1. ����ڰ� ���콺 ���� ��ư�� �������� Ȯ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            if (useArray)
            {
                // ������Ʈ Ǯ ���(�迭 ���)���� �Ѿ� ���
                ObjectPoolArrayType();
            }

            else if (useObjectPool)
            {
                // ������Ʈ Ǯ ������� �Ѿ� ���
                ObjectPoolType();
            }
            

            if(!useObjectPool && !useArray) 
            {
                // �⺻ ������� �Ѿ��� ����
                InstantiateType();
            }

            // �Ѿ� �߻����� �����Ѵ�.
            audioSource.clip = sounds[0];
            audioSource.volume = 0.2f;
            audioSource.Play();
            // audioSource.Stop();
            // audioSource.Pause();
           
        }
        #region �� �� �̻� �Ѿ��� �߻��� ���
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
        #endregion

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

    void InstantiateType()
    {
        // �Ѿ��� �����Ѵ�.
        GameObject go = Instantiate(bulletPrefab);

        // 3-1. �ѱ��� ���� ������Ʈ ������ ���� �����ϴ� ���
        go.transform.position = firePosition.transform.position;
        go.transform.rotation = firePosition.transform.rotation;

        // 3-2. �÷��̾��� ��ġ���� ���� 1.5���� ������ �����ϴ� ���
        // Vector3 firePos = transform.position + new Vector3(0, 1.5f, 0);
        // go.transform.position = firePos;

        ;
    }

    void ObjectPoolType()
    {
        // 0�� �ε����� �Ѿ��� Ȱ��ȭ�Ѵ�.
        bullets[0].SetActive(true);

        // Ȱ��ȭ�� �Ѿ��� ��ġ �� ȸ���� �ѱ��� ��ġ��Ų��.
        bullets[0].transform.position = firePosition.transform.position;
        bullets[0].transform.rotation = firePosition.transform.rotation;
        bullets[0].GetComponent<BulletMove>().player = gameObject;

        // Ȱ��ȭ�� �Ѿ��� �ڽ� ������Ʈ���� �����Ѵ�.
        bullets[0].transform.parent = null;

        // 0�� �ε����� �Ѿ� ������Ʈ�� źâ ����Ʈ���� �����Ѵ�.
        bullets.RemoveAt(0);
    }

    void ObjectPoolArrayType()
    {
        
        // bulletNumber�� ���� ���� ��ȣ�� �����ϵ��� �Ѵ�.
        // bulletNumber = (bulletNumber + 1) % bulletArray.Length;
        for(int i = 0; i < bulletArray.Length; i++)
        {
            if (bulletArray[i] != null)
            {
                // �ش� �ε����� �Ѿ� ������Ʈ�� Ȱ��ȭ ���������� Ȯ���Ѵ�.
                if (!bulletArray[i].activeInHierarchy)
                {
                    // bulletNumber ���� ���� �ش��ϴ� �ε����� ������Ʈ�� Ȱ��ȭ�Ѵ�.
                    bulletArray[i].SetActive(true);

                    // Ȱ��ȭ�� �Ѿ��� ��ġ �� ȸ�� ���� �ѱ��� ��ġ��Ų��.
                    bulletArray[i].transform.position = firePosition.transform.position;
                    bulletArray[i].transform.rotation = firePosition.transform.rotation;

                    // Ȱ��ȭ�� �Ѿ��� �ڽ� ������Ʈ���� �����Ѵ�.
                    bulletArray[i].transform.parent = null;

                    // �迭���� �ش� �Ѿ��� �����Ѵ�.
                    bulletArray[i] = null;
                    break;
                }
            }
        }
    }

    // ���� ȿ������ �÷����ϴ� �Լ�
    public void PlayExPlosionSound()
    {
        audioSource.clip = sounds[1];
        audioSource.volume = 1.0f;
        audioSource.Play();
    }
}
