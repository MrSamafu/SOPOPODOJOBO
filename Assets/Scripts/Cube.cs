using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    float speed;

    private void Awake()
    {
      
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
            
    }

    private void OnMouseDown()
    {
        this.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
