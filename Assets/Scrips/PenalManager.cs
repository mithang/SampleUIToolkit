using System.Collections;
using System.Collections.Generic;
using Unity.UIElements.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PenalManager : MonoBehaviour
{
    public PanelRenderer MainMenuScreen;

    private void OnEnable()
    {
       
        MainMenuScreen.postUxmlReload += BindMainMenuScreen;
    }

    private IEnumerable<Object> BindMainMenuScreen()
    {
        Debug.Log("ok1");
        var root = MainMenuScreen.visualTree;
        var startButton = root.Q<Button>("start-button");
        if (startButton != null)
        {
            Debug.Log("ok2");
            startButton.clickable.clicked += () =>
            {
                //Debug.Log("Start Button Clicked");
                SceneManager.LoadScene("Setting");
            };
        }
        return null;
    }
}
