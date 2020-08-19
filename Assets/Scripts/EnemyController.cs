using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
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
        transform.LookAt(PlayerController.instance.transform.position);

        theRB.velocity = transform.forward * moveSpeed;
    }
}
