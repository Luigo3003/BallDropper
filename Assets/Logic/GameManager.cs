using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int CurrentScore { get; set; }

    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject EndGameCanvas;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _scoreText.text = CurrentScore.ToString("0");
        Time.timeScale = 0f;
    }


    public void IncreaseScore()
    {
        CurrentScore++;
        _scoreText.text = CurrentScore.ToString("0");

    }

    public void EndGame()
    {
        Time.timeScale = 0;
        EndGameCanvas.SetActive(true);
    }

    public void ResetGame()
    {
        PoolScript.PSInstance.TurnOnObjects();
    }
}
