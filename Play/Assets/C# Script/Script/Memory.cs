using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //private �� �ڽŸ� �����Ͽ� ���
    //public �ܺο��� �����Ͽ� ���
    //protected �� �ڽŰ� ����ϰ� �ִ� Ŭ�������� ���

    protected int health;
    protected int attack;
    public string name;
    public void Information()
    {
        print(health);
        print(attack);
        print(name);
    }
}


//�ڵ� ���� : ���α׷� ����Ǵ� �ڵ�����
//������ : ���������� �������� ����
//�� : �������� ������ �޸� ����
//���� : ���������� �Լ��� �Ű� ��������


//void : �ڷ����� �������� �ʴ´�.
public class Memory : Monster
{

    public int value = 100; //MonoBehaviour���� ������ �� �� ����.

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        attack = 100;
        Information();
        Move();

        int value = 250;
        value = 100;
        int area = 500;
    }

    private void Update()
    {

        Move();
        //Calculator(5,2);
        print(add(10, 10));
    }


    void Move() //������ �̵���Ű�� �Լ� 
    {
        //+= ���� ���ϸ鼭 ������ ������.
                
        transform.position += new Vector3(1, 1, 0) * Time.deltaTime;
    }

    private void Calculator(int x, int y)
    {
        int temp;
        temp = x + y;
        print(temp);
    }

    int add(int x, int y)
    {
        return x + y;
    }
}
