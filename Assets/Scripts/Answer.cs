using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizmg;
    public void Answers()
    {
        if (isCorrect)
        {
            Debug.Log("Correct");
            quizmg.Correct();
        }
        else
        {
            Debug.Log("Wrong");
            quizmg.Correct();
        }
    }
}
