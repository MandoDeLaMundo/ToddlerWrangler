using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speed = 10.0f;
    float zRot = 0.0f;
    float rotSpeed = 400.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += transform.up * speed * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += transform.up * -speed * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.D))
        {
            zRot -= rotSpeed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, zRot);
        }

        if (Input.GetKey(KeyCode.A))
        {
            zRot += rotSpeed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, zRot);
        }

    }
}
