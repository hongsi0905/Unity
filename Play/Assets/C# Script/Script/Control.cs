using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    /*
    int 4byte �޸� ��������, ����������
    string ���ڿ� �ֵ���ǥ
    float �Ǽ��� f�ٿ��ֱ�
    char ����(�ϳ���) ����ǥ
    */

    public int hp = 100; 
    public string name = "Mob"; 
    float height = 33.6f;
    char bloodtype = 'X';

    // Start is called before the first frame update
    void Start()
    {
        //������ �Ӽ��� �ʱ�ȭ �� �� ���
        print(hp);
        print(name);
        print(height);
        print(bloodtype);
    }

    // Update is called once per frame
    void Update()
    {
        //������ �Է��̳� ��ġ�̵��� ���
    }
}
