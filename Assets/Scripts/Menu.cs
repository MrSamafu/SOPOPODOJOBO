using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jouer()
    {
        
        GameObject.Find("GameManager").GetComponent<GameManager>().LobbyPassword = GameObject.Find("API").GetComponent<BDD>().CreateGame();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Lobby");

    }

    public void Quitter()
    {
        Application.Quit();
    }
}
