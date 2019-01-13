using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelMenu : MonoBehaviour
{
    Button[] button;
    int levelReached;

    void Start()
    {
        levelReached = PlayerPrefs.GetInt("levelReached", 1);
        button = FindObjectsOfType<Button>();

        foreach (Button btn in button)
        {
            if (Int32.Parse(btn.name) > levelReached)
            {
                btn.interactable = false;
            }
        }
    }

    public void SelectLevel(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void SelectLevelv2()
    {
        SceneManager.LoadScene(Int32.Parse(EventSystem.current.currentSelectedGameObject.name));
    }
}