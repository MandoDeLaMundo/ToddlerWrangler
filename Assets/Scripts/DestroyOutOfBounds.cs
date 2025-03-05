using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float mTopBound = 30.0f;
    private float mLeftBound = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > mTopBound)
            Destroy(gameObject);
        else if (transform.position.y < -mTopBound)
            Destroy(gameObject);
        else if (transform.position.x < -mLeftBound)
            Destroy(gameObject);
        else if (transform.position.x > mLeftBound)
            Destroy(gameObject);
    }
}
