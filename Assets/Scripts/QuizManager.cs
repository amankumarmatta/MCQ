using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QnA> QuesAndAns;
    public GameObject[] options;
    public int questionIndex;

    public GameObject QuizPanel;
    public GameObject GOPanel;

    public Text questionTxt;
    public Text scoreTxt;

    int totalQuestions = 0;
    public int scoreCount = 0;

    private void Start()
    {
        totalQuestions = QuesAndAns.Count;
        GOPanel.SetActive(false);
        DisplayQuestions();
    }

    void GameOver()
    {
        QuizPanel.SetActive(false);
        GOPanel.SetActive(true);
        scoreTxt.text = scoreCount + "/" + totalQuestions;
    }

    void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void correct()
    {
        scoreCount++;
        QuesAndAns.RemoveAt(questionIndex);
        DisplayQuestions();
    }

    public void wrong()
    {
        QuesAndAns.RemoveAt(questionIndex);
        DisplayQuestions();
    }

    public void DisplayQuestions()
    {
        if (QuesAndAns.Count > 0)
        {
            questionIndex = Random.Range(0, QuesAndAns.Count);

            questionTxt.text = QuesAndAns[questionIndex].Question;
            SetOptions();
        }
        else
        {
            Debug.Log("QUESTIONS OVER");
            GameOver();
        }
    }

    public void SetOptions()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<QuestionChecker>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QuesAndAns[questionIndex].Answers[i];
            if (QuesAndAns[questionIndex].CorrectAns == i+1)
            {
                options[i].GetComponent<QuestionChecker>().isCorrect = true;
            }
        }
    }

    [System.Serializable]
    public class QnA
    {
        public string Question;
        public string[] Answers;
        public int CorrectAns;
    }
}

