using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.5f;
    public float rotationSpeed = 100f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0, 0, - speed * Time.deltaTime)); 
        }

        else if  (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, - rotationSpeed * Time.deltaTime, 0));
        }
    }
}
