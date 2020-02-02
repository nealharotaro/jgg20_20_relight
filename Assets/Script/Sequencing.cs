using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencing : MonoBehaviour
{
    // Start is called before the first frame update
    private int answer,index;
    private int[] question;
    public GameObject[] questions;
    public static Sequencing instance;

    void Start()
    {
        instance = this;
        answer = 0;
        question = new int[3];
        question[0] =9;
        question[1] = 6;
        question[2] = 2;
        if(index==1)
        {
            questions[0].gameObject.SetActive(true);
            questions[0].gameObject.SetActive(false);
            questions[0].gameObject.SetActive(false);
        }
        if (index == 1)
        {
            questions[0].gameObject.SetActive(false);
            questions[0].gameObject.SetActive(true);
            questions[0].gameObject.SetActive(false);
        }
        if (index == 2)
        {
            questions[0].gameObject.SetActive(false);
            questions[1].gameObject.SetActive(false);
            questions[2].gameObject.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        answer = 0;
    }
    public void sequenceCheck()
    {
        if(answer==question[index])
        {
            this.gameObject.SetActive(false);
            index++;
        }
    }
    public void b1()
    {
        answer += 1;
        Debug.Log("1");
    }
    public void b2()
    {
        answer += 2;
    }
    public void b3()
    {
        answer += 3;
    }
    public void b4()
    {
        answer += 4;
    }
    public void b5()
    {
        answer +=5;
    }
    public void b6()
    {
        answer += 6;
    }
    public void b7()
    {
        answer +=7;
    }
    public void b8()
    {
        answer +=8;
    }
    public void b9()
    {
        answer += 9;
    }
}
