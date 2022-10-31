using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    [SerializeField]EndScreen endScreen;

    private void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
    }

    private void Start()
    {
        quiz.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
