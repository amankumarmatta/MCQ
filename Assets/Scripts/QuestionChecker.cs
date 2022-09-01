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
            Image img = GetComponent<Image>();
            quizmg.correct(img);
            Debug.Log("Correct");
        }
        else
        {
            Image img = GetComponent<Image>();
            quizmg.wrong(img);
        }
    }
}
