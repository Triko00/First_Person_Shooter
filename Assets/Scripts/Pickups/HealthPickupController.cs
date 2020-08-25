using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupController : MonoBehaviour
{
    private bool isCollected = false;

    public int healAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !isCollected)
        {
            PlayerHealthController.instance.HealPlayer(healAmount);

            Destroy(gameObject);

            AudioManager.instance.PlaySFX(4);

            isCollected = true;
        }
    }
}
