using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 rot=new Vector3(0,0,0.1f);

    // Start is called before the first frame update
    void Start()
    {
        this.transform.localRotation *= Quaternion.Euler(1f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localRotation *= Quaternion.Euler(0f, 0f, 0.05f);
        }else
        if (Input.GetKey(KeyCode.D)) 
        {
            this.transform.localRotation *= Quaternion.Euler(0f, 0f, -0.05f);
        }else
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.localRotation *= Quaternion.Euler(0.05f, 0f, 0f);
        }else
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localRotation *= Quaternion.Euler(-0.05f, 0f, 0f);
        }
    }
}
