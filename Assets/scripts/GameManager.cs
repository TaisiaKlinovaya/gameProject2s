using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] PlayerText;

    [HideInInspector] public int firstPlayerScore = 0;
    [HideInInspector] public int secondPlayerScore = 0;

    [Header("----------------------------------")]

    [Space]
    [SerializeField] private float gameTime = 60f;
    [SerializeField] private int time = 10;
    [SerializeField] private GameObject EndCanves;
    [SerializeField] private TextMeshProUGUI timeUI;

    private void Update()
    {
        ScorManager(firstPlayerScore, secondPlayerScore);
        StartCoroutine(GameTimer(time));
    }

    private IEnumerator GameTimer(float GameTime)
    {
        yield return new WaitForSeconds(GameTime);
        gameTime--;
        timeUI.text = gameTime.ToString();
        if (gameTime <= 0)
        {
            Time.timeScale = 0;
            EndCanves.SetActive(true);
        }
    }

    private void ScorManager(int firstPlayerScore, int secondPlayerScore)
    {
        PlayerText[0].text = "Player 1: " + firstPlayerScore.ToString();
        PlayerText[1].text = "Player 2: " + secondPlayerScore.ToString();
    }
}
