using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionChecker : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizmg;
    public void QuestionCheck()
    {
        if (isCorrect)
        {
            Debug.Log("Correct");
            quizmg.correct();
        }
        else
        {
            Debug.Log("Wrong");
            quizmg.wrong();
        }
    }
}
