using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } //Encapsulation
    [SerializeField] private TextMeshProUGUI nameField;
    private TextMeshProUGUI mainNameField;
    private string playerName;
    private bool nameEntered;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        //Abstraction
        UpdatePlayerName();
    }

    public void PlayGame() 
    {
        playerName = nameField.text;
        SceneManager.LoadScene(1);
    }

    public void UpdatePlayerName()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Game" && nameEntered == false)
        {
            mainNameField = GameObject.Find("PlayerName").GetComponent<TMPro.TextMeshProUGUI>();
            mainNameField.text = "Player Name: " + playerName;
            nameEntered = true;
        }
    }
}
