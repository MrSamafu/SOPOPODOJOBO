using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMission2 : MonoBehaviour
{
    public int Mission;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Mission = GameObject.Find("GameManager").GetComponent<GameManager>().MissionInt;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void jouer()
    {

        GameObject.Find("GameManager").GetComponent<GameManager>().MissionInt +=1 ;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
       
    }
}

