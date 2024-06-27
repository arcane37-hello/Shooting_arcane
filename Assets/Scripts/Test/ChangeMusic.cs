using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    // ���� ���� �迭 ����
    public AudioClip[] soundClip;

    AudioSource musicPlayer;

    void Start()
    {
        // ����� �ҽ� ������Ʈ�� ������ ĳ���ϱ�
        musicPlayer = GetComponent<AudioSource>();

    }

    void Update()
    {
        // ����, Ű������ ���� Ű 1���� ������
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // ���� Ŭ�� �迭�� 0�� ���� ������ �����Ѵ�.
            ChangeSoundClip(0);
        }
        // �׷��� �ʰ� ����, Ű������ ���� Ű 2���� ������
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // ���� Ŭ�� �迭�� 1�� ���� ������ �����Ѵ�.
            ChangeSoundClip(1);
        }
        // �׷��� �ʰ� ����, Ű������ ESC Ű�� ������
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            // ����� �ҽ��� �ߴ��Ѵ�.
            musicPlayer.Stop();
        }

    }

    void ChangeSoundClip(int clipNumber)
    {
        // 1. ���� ���� ����� �ҽ��� �����Ѵ�.
        musicPlayer.Stop();

        // 2. ���� �迭���� 0��°�� ����� �ҽ��� �ִ´�.
        musicPlayer.clip = soundClip[clipNumber];

        // 3. ����� �ҽ��� �÷����Ѵ�.
        musicPlayer.Play();
    }
}