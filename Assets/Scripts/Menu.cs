using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject historyyPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("level01");
    }

    public void ShowHistory()
    {
        historyyPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        historyyPanel.SetActive(false);
    }
}
