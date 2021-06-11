using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     if (GameObject.Find("GameManager").GetComponent<GameManager>().MissionInt == 1)
        {
            GameObject.Find("Capsule (1)").transform.position = new Vector3(820, 28, 68);
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
