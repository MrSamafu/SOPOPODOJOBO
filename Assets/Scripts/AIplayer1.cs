using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIplayer1 : MonoBehaviour
{
    public NavMeshAgent agent;

   
    [SerializeField]
    GameObject gameObj6;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AIplayer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
         agent.SetDestination(gameObj6.transform.position);
    }

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
      if(collision.transform.tag == "Cube27")
        {
           
            UnityEngine.SceneManagement.SceneManager.LoadScene("SceneMission2");
        }

    }
}
