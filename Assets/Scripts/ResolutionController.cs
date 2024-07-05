using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionController : MonoBehaviour
{
    public Text text_res;

    Camera myCam;

    void Start()
    {
        // �ػ󵵸� �����ϱ�
        Screen.SetResolution(540, 960, false);

        // ī�޶��� Orthographic size�� ���� �����Ѵ�.
        myCam = GetComponent<Camera>();
        myCam.orthographicSize = (float)Screen.height / 200.0f;
    }

    void Update()
    {
        // ���� ��ũ���� �ʺ�� ���� �ػ� ���� ����Ѵ�.
        int res_x = Screen.width;
        int res_y = Screen.height;

        string resText = "Width: " + res_x.ToString() + "\nHeight:" + res_y.ToString();
        text_res.text = resText;
    }
}
