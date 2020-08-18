using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletController : MonoBehaviour
{

    public float moveSpeed;

    public Rigidbody theRB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.forward * moveSpeed;
    }

    private void OnTriggerEnter()
    {
    }
       
}
