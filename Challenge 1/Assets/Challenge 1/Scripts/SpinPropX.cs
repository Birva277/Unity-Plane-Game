using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropX : MonoBehaviour
{
    public float vertiInput;
    public float rotSpeed=20f;
    public float speed = 0;
    public float forwardInput=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertiInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward * rotSpeed * vertiInput);
    }
}
