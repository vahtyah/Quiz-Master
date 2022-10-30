using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    public bool loadNextQuestion;
    public bool isAnsweringQuestion = false;
    public float fillFaction;
    float timerValue;

    private void Update()
    {
        UpdateTime();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTime()
    {
        timerValue -= Time.deltaTime;
        if (isAnsweringQuestion)
        {

            if (timerValue > 0)
                fillFaction = timerValue / timeToCompleteQuestion;
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
                fillFaction = timerValue / timeToShowCorrectAnswer;
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }
    }
}
