using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quizz quiz;
    EndScreen endScreen;
    void Awake(){
        quiz = FindAnyObjectByType<Quizz>();
        endScreen = FindAnyObjectByType<EndScreen>();
    }
    void Start()
    {
        quiz.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (quiz.isComplete){
            quiz.gameObject.SetActive(false);
            endScreen.gameObject.SetActive(true);
            endScreen.ShowFinalScore();
        }
    }

    public void OnReplayLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
