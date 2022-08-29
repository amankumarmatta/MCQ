using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQues;

    public Text QuestionTxt;

    private void Start()
    {
        generateQuestion();
    }

    public void Correct()
    {
        QnA.RemoveAt(currentQues);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQues].Answers[i];

            if(QnA[currentQues].CrctAnswer == i+1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQues = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQues].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of questions.");
        }
    }
}
