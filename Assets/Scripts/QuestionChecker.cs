using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionChecker : MonoBehaviour
{
    public bool isCorrect = true;
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
