using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0,0,0.1f));
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(new Vector3(0, 0, -0.1f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0.1f, 0, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(-0.1f, 0, 0));
        }
    }
}
