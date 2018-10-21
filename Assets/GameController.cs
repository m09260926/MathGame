using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int answer;
    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject repeat;

    public int option;

    // Use this for initialization
    void Start()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateQuestion()
    {
        //產生題目
        int a = Random.Range(1, 11);
        int b = Random.Range(1, 11);
        answer = a * b;

        //產生選項
        int option = Random.Range(0, 3);             //宣告option為隨機的0或1或2

        if (option == 0) //option1是答案 23是錯的
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option3.GetComponent<TextMesh>().text = (answer - Random.Range(1, 4)).ToString();
            option1.GetComponent<Option>().isCorrect = true;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = false;
        }

        else if (option == 1) //option2是答案 13是錯的

        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer - Random.Range(1, 4)).ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = true;
            option3.GetComponent<Option>().isCorrect = false;
        }

        else    //option3是答案 12是錯的       

        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(1, 4)).ToString();
            option2.GetComponent<TextMesh>().text = (answer - Random.Range(1, 4)).ToString();
            option3.GetComponent<TextMesh>().text = answer.ToString();
            option1.GetComponent<Option>().isCorrect = false;
            option2.GetComponent<Option>().isCorrect = false;
            option3.GetComponent<Option>().isCorrect = true;
        }

        question.GetComponent<TextMesh>().text = a + " " + "*" + " " + b + " =? ";
   
    }

    public void Orange(){
            
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
        }

        else if (option == 1)
        {
            option2.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
        }

        else
        {
            option3.GetComponent<TextMesh>().color = new Color(1.0f, 0.5f, 0.0f, 1.0f);
        }
    }
} 