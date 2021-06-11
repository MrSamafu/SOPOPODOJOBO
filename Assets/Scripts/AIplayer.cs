using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIplayer : MonoBehaviour
{

    public Camera Cam;

    public NavMeshAgent agent;

    [SerializeField]
    GameObject gameObj;
    [SerializeField]
    GameObject gameObj1;
    [SerializeField]
    GameObject gameObj2;
    [SerializeField]
    GameObject gameObj3;
    [SerializeField]
    GameObject gameObj4;
    [SerializeField]
    GameObject gameObj5;
    [SerializeField]
    GameObject gameObj6;




    // Start is called before the first frame update
    void Start()
    {
      GetComponent<AIplayer1>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
       
        agent.SetDestination(gameObj6.transform.position);
        
       
    }
    public void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.transform.tag == "Cube6")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
        }

    }
}
