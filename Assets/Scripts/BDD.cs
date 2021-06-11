using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class BDD : MonoBehaviour
{
    public string urlCreate = "http://localhost/API/game/create.php";
    public string urlGet = "http://localhost/API/game/read.php";
    private string code;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetGame()
    {
        StartCoroutine(GetGames());
    }
    public string CreateGame()
    {
        StartCoroutine(PostGame());
        return code;
    }
    IEnumerator PostGame()
    {
        

        List<IMultipartFormSection> UWR = new List<IMultipartFormSection>();
        code = Random.Range(1000, 10000).ToString();
        
        UWR.Add(new MultipartFormDataSection("lobby_password", code));

        UnityWebRequest www = UnityWebRequest.Post(urlCreate, UWR);
        yield return www.SendWebRequest();
        if(www.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(www.error);
        }
        else
        {
        }

    }
    IEnumerator GetGames()
    {
        UnityWebRequest UWR = UnityWebRequest.Get(urlGet);
        yield return UWR.SendWebRequest();

        if (UWR.result == UnityWebRequest.Result.ConnectionError)
        {
            Debug.Log(UWR.error);
        }
        else
        {
        }


    }
}
