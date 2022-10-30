using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int coreectAnswers = 0;
    int questionsSeen = 0;

    public int GetCorrectAnswers()
    {
        return coreectAnswers;
    }

    public void IncrementCorrectAnswers()
    {
        coreectAnswers++;
    }

    public int GetQuestionsSeen()
    {
        return questionsSeen;
    }

    public void IncrementQuestionsSeen()
    {
        questionsSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(coreectAnswers / questionsSeen * 100);
    }
}
