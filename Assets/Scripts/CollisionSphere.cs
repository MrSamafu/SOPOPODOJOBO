using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
 
        this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 500, 0)); 
        }
    }
}
