﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] AudioClip _startingSong;
    [SerializeField] Text _highScoreTextView;

    // Start is called before the first frame update
    void Start()
    {
        // load high score display
        int highScore = PlayerPrefs.GetInt("HighScore");
        _highScoreTextView.text = highScore.ToString();

        // play starting song on Menu Start
        if (_startingSong != null)
        {
            AudioManager.Instance.PlaySong(_startingSong);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Reset()
    {
        int highScore = 0;
        _highScoreTextView.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
