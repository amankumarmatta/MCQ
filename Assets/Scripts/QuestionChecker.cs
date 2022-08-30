using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionChecker : MonoBehaviour
{
    public bool isCorrect;
    public QuizManager quizmg;
    public void QuestionCheck()
    {
        if (isCorrect)
        {             
            quizmg.correct();
            Debug.Log("Correct");
        }
        else
        {            
            quizmg.wrong();
        }
    }
}
