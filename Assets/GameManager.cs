using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public string LobbyPassword;
    public int MissionInt;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

   public string GetLobbyPassword()
    {
        return LobbyPassword;
    }

}
