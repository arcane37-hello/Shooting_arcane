using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // �÷��̾ ���ϴ� �������� �̵��Ѵ�.
    // ����, �ӷ� = �ӵ� (Vector)

    public float moveSpeed = 0.1f;
    public float rotSpeed = 100;
    // Vector3 direction;

    float rotY;
    Animator myAnim;

    // ó�� �����Ǿ��� �� �� ���� ����Ǵ� �Լ�
    void Start()
    {
        // ������ �پ��ִ� Animator ������Ʈ ��������
        myAnim = GetComponent<Animator>();
    }

    // �� �����Ӹ��� �ݺ��ؼ� �����ϴ� �Լ�
    void Update()
    {
        #region �̵� ���� ���� ���
        // �̵� ����: p = p0 + vt


        // Vector3 direction =  new Vector3(1, 1, 0);
        // transform.position += Vector3.right * moveSpeed;
        // transform.position += direction * moveSpeed;

        // print(transform.position);
        #endregion

        // ������� �Է� �ޱ�
        // float h = Input.GetAxis("Horizontal");
        float h = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, z, 0);
        // ������ ���̸� ������ 1�� �ٲ۴�. (����ȭ)
        direction.Normalize();

        // �̵� ����: p = p0 + vt
        transform.position += direction * moveSpeed * Time.deltaTime;
        // transform.eulerAngles += direction * moveSpeed * Time.deltaTime;
        // transform.localScale += direction * moveSpeed * Time.deltaTime;

        // ��ü�� ȸ�� r = r0 + vt
        rotY += (h * -1) * rotSpeed * Time.deltaTime;
        transform.eulerAngles += new Vector3(0, rotY, 0);

        // ����, ������� �¿� �Է��� ���ٸ�...
        float inputH = Mathf.Abs(h);
        if (inputH < 0.1f)
        {
            // ��ü�� ȸ������ �ٽ� ������� �������´�.
            // transform.eulerAngles = Vector3.zero;

            #region 1.���Ϸ� �ޱ��� ���� ����ϴ� ���
            // if (Mathf.Abs(transform.eulerAngles.y) > 1.0f)
            // {

            //    if (transform.eulerAngles.y < 0)
            //    {
            //        rotY += rotSpeed * Time.deltaTime;                 
            //    }
            //    else
            //    {
            //        rotY -= rotSpeed * Time.deltaTime;
            //    }
            // }
            // else
            // {
            //    transform.eulerAngles = Vector3.zero;
            // }
            #endregion

            // 2. Lerp�� �̿��� ���
            rotY = Mathf.Lerp(rotY, 0, Time.deltaTime);
            transform.eulerAngles = new Vector3(0, rotY, 0);
        }

        // 3. �ִϸ����͸� ����� ȸ�� �ִϸ��̼� �ֱ�
        // if (h > 0.2f)
        // {
        //    myAnim.SetTrigger("RightMove");
        // }
        // else if(h < -0.2f)
        // {
        //    myAnim.SetTrigger("LeftMove");
        // }
        // else
        // {
        //    myAnim.SetTrigger("Idle");
        // }

        #region ������� Ű �Է� �̺�Ʈ
        // Ư�� Ű�� �Է����� �� ����ϴ� �Լ�(Get, GetDown, GetUp)
        // bool value = Input.GetButton("Horizontal");

        // if(Input.GetKey(KeyCode.F1))
        // {
        //    print("F1 Ű�� �������ϴ�!");
        // }
        #endregion


    }
}
