using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applegrounded : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        print("Elma yere degdi");

        if (other.CompareTag("Apple"))
        {
            HealthManager.instance.DecreaseHealth();
            Destroy(other.gameObject);

        }
    }
}
