using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderArrow : MonoBehaviour
{
    Rigidbody rib;
    // Start is called before the first frame update
    void Start()
    {
         rib = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
     this.transform.SetParent(collision.transform);
        if(this.GetComponent<Rigidbody>() != null)
        Destroy(rib);
    }
}
