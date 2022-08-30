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
            quizmg.correct();
        }
        else
        {            
            quizmg.wrong();
        }
    }
}
