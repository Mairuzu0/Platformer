﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DentedPixel;

public class Menu : MonoBehaviour
{
    [System.Serializable]
    public class TweenScale
    {
        public string name;
        public GameObject tweenText;
        public Vector3 tweenSize;
        public float tweenTime;
        public float tweenDelayTime;
    }

    public TweenScale[] tweenArray;

    private void Awake()
    {
        //Start Tween
        for (int i = 0; i < tweenArray.Length; i++)
        {
            LeanTween.scale(tweenArray[i].tweenText, tweenArray[i].tweenSize, tweenArray[i].tweenTime).setEase(LeanTweenType.linear).setDelay(tweenArray[i].tweenDelayTime);

        }

    }



    public void StartFirstLevel()
    {
        SceneManager.LoadScene("World Map");
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}