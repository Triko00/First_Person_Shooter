using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickupController : MonoBehaviour
{
    public string theGun;

    private bool collected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !collected)
        {
            PlayerController.instance.AddGun(theGun);

            Destroy(gameObject);

            collected = true;
        }
    }
}
