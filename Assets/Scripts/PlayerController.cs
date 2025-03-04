using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float mSpeed = 10.0f;
    float mZRot = 0.0f;
    float mRotSpeed = 400.0f;
    int mBabiesHeld = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.mIsGameActive == true)
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
            gameObject.transform.position += transform.up * mSpeed * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.S))
            gameObject.transform.position += transform.up * -mSpeed * Time.deltaTime;
        

        if (Input.GetKey(KeyCode.D))
        {
            mZRot -= mRotSpeed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, mZRot);
        }

        if (Input.GetKey(KeyCode.A))
        {
            mZRot += mRotSpeed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, mZRot);
        }

    }

    void DropOffBabies()
    {
        Debug.Log("Babies dropped off");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        DropOffBabies();
    }
}
