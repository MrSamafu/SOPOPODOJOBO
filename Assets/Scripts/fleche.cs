using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleche : MonoBehaviour
{
    [SerializeField]
    public Transform _prefab;

    [SerializeField]
    Transform container;
  

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // Instancier avec la touche T
        //if (Input.GetKeyDown("t"))
        //{

        //    Transform newGameObj = Instantiate(_prefab) as Transform;
        //    newGameObj.position = transform.position + transform.forward;
        //    newGameObj.LookAt(this.transform);

        //}

        if (Input.GetMouseButtonDown(0))
        {

            // fait par l'intervenant
            Transform clone = Instantiate(_prefab);
            clone.position = this.transform.position + this.transform.forward;
            clone.LookAt(this.transform);
            clone.SetParent(container);
            clone.GetComponent<Rigidbody>().AddForce( this.transform.forward * 1500);
            }

    }



}
