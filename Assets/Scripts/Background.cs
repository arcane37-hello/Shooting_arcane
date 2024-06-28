using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // ��Ƽ������ uv offset ���� �����ؼ� ��ũ�� ȿ���� �ְ� �ʹ�.
    // ��ũ�� ������ �Ʒ������� �Ѵ�.
    // p = p0 + vt ����, �ӷ�

    public float scrollSpeed = 0.2f;

    MeshRenderer mr;

    void Start()
    {
        // Mesh Renderer ������Ʈ�� ĳ���Ѵ�.
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {

        if (mr != null)
        {
            // Mesh Render ������Ʈ�� �ִ� Materials �迭���� 0��° ��Ƽ������ �����´�.
            Material mat = mr.materials[0];

            // ��Ƽ������ offset �Ӽ� ���� y�� ���� �����Ѵ�.
            mat.mainTextureOffset += new Vector2(0, 1) * scrollSpeed * Time.deltaTime;
        }

    }
}
