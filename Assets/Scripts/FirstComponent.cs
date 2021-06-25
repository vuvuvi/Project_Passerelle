using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstComponent : MonoBehaviour
{

    //// Update is called once per frame

    public float rotationSpeed;

    public bool reverse;

    public Vector3 rotationAxis;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inside the start function");
    }

    void Update()
    {
        rotationAxis = new Vector3(0, 1, 0);
        if (reverse)
        {
            transform.Rotate(-rotationAxis* rotationSpeed * Time.deltaTime, Space.World);
        } else
        {

            transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
