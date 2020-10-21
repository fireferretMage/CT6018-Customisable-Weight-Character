using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //if button clicked rotate object
    public void RotateLeft()
    {
        transform.Rotate(Vector3.up, 45.0f);
    }

    //if button clicked rotate object
    public void RotateRight()
    {
        transform.Rotate(Vector3.up, -45.0f);

    }
}
