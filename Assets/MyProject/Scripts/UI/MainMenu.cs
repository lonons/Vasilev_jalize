using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startGame;
    [SerializeField] private Button quit;
    [SerializeField] private Button settings;
    [SerializeField] private string gameScene = "level1";
    [SerializeField] private Canvas canvasSettings;

    private void Awake()
    {
        startGame.onClick.AddListener(StartGame);
        quit.onClick.AddListener(Quit);
        settings.onClick.AddListener(Settings);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(gameScene);
    }

    private void Settings()
    {
        canvasSettings.gameObject.SetActive(true);
    }

    private void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
