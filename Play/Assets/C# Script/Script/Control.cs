using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    /*
    int 4byte 메모리 공간생성, 공간값저장
    string 문자열 쌍따옴표
    float 실수면 f붙여주기
    char 문자(하나만) 따옴표
    */

    public int hp = 100; 
    public string name = "Mob"; 
    float height = 33.6f;
    char bloodtype = 'X';

    // Start is called before the first frame update
    void Start()
    {
        //옵젝의 속성을 초기화 할 때 사용
        print(hp);
        print(name);
        print(height);
        print(bloodtype);
    }

    // Update is called once per frame
    void Update()
    {
        //옵젝의 입력이나 위치이동시 사용
    }
}
