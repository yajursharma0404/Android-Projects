using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }
}
