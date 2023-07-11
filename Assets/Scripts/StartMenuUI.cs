using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartMenuUI : MonoBehaviour
{
    public TMP_InputField inputName;
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.LoadScore();
        scoreText.text = "Best Score: " + DataManager.Instance.playerNameBest + ": " + DataManager.Instance.bestScore;
        inputName.text = DataManager.Instance.playerNameBest;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DataManager.Instance.savePlayerName = inputName.text;
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); 
        #endif
    }

}
