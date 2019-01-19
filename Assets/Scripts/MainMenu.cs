﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("levelReached", 1));
    }

    public void Levels()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}