using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireboycolsiion : MonoBehaviour
{
    Vector3 starpos;
    // Start is called before the first frame update
    void Start()
    {
        starpos = transform.position;
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "cuboazul" || col.gameObject.name == "cubotoxico")
        {
            miAM.PlayClip();
            transform.position = starpos;
        }

    }
}

