using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ��Ȳ�� ���� ó��
        //Debug.Log("test");
        //Debug.LogWarning("This is a warning message!");
        //Debug.LogError("This is an error message!");

        //GameObject => Ŭ������
        //gameObject => Ŭ���� �Ļ���
        //C#���� Vector������ ��� ����Ƽ���� Ŭ���� �߰�

        //�̵�
        //this.gameObject.transform.position += new Vector3(3, 0, 0);
        //this.transform.position += new Vector3(3, 0, 0);

        //ȸ��
        //this.gameObject.transform.rotation = Quaternion.Euler(90.0f, 90.0f, 0.0f);

        //Ȯ��/���
        transform.localScale = new Vector3(1f, 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
