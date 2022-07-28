using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Various : MonoBehaviour
{
    private float Timer;
    public Image stateimage;
    public Sprite[] stateicon;

    void Start()
    {
        InvokeRepeating("Position", 1, 3);

        StartCoroutine(Paint());
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if(Timer > 5.0f)
        {
            Invoke("ChangeSprite", 0);

            Timer = 0.0f;
        }
    }

    public IEnumerator Paint()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);

            gameObject.GetComponent<Renderer>().material.color = new Color
                (
                    Random.Range(0, 2),
                    Random.Range(0, 2),
                    Random.Range(0, 2)
                );
        }
    }

    public void ChangeSprite()
    {
        switch (Random.Range(0, 3))
        {
            case 0: 
                stateimage.sprite = stateicon[0];
                break;
            case 1:
                stateimage.sprite = stateicon[1];
                break;
            case 2:
                stateimage.sprite = stateicon[2];
                break;
        }
    }

    public void Position()
    {
        transform.position = new Vector3
            (
                Random.Range(-2.5f, 2.5f), 0, Random.Range(-2.5f, 2.5f)
            );
    }
}
