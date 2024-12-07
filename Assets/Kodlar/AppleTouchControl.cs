using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class AppleTouchControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            print("Elma sepete girdi tebrikler");
            ScoreManager.instance.IncreaseScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SpawnBoxManager.instance.SpawnBox();
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            print("Elma yere deðdi");
            HealthManager.instance.DecreaseHealth();
            Destroy(gameObject);
        }
    }
}
