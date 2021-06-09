using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFleche : MonoBehaviour
{
 
    Vector3 firstPosition;
    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        lastPosition = this.transform.position;
        if (Vector3.Distance(firstPosition, lastPosition) > 400)
        {
            Destroy(gameObject);
        }else
        {
            Destroy(gameObject, 1);
        }


     
    }
}
