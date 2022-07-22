using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    //private 나 자신만 접근하여 사용
    //public 외부에서 접근하여 사용
    //protected 나 자신과 상속하고 있는 클래스까지 사용

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


//코드 영역 : 프로그램 실행되는 코드저장
//데이터 : 전역변수와 정적변수 저장
//힙 : 동적으로 생성한 메모리 관리
//스택 : 지역변수와 함수의 매개 변수저장


//void : 자료형이 존재하지 않는다.
public class Memory : Monster
{

    public int value = 100; //MonoBehaviour에서 가져가 쓸 수 없다.

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


    void Move() //옵젝을 이동시키는 함수 
    {
        //+= 값을 더하면서 누적해 나간다.
                
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
