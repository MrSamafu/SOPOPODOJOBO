using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
   
    public Text textcode, textEquipeR, textEquipeB;


    // Start is called before the first frame update
    void Start()
    {
        textcode.text = GameObject.Find("GameManager").GetComponent<GameManager>().LobbyPassword;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
