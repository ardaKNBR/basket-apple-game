using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;
    public TMP_Text healthText;
    public int health;

    public void Awake()
    {
        instance = this;
    }
    public void DecreaseHealth()
    {
        if (health > 0)
        {
            health--;
            healthText.SetText(health.ToString());
        }
        if (health <= 0)
        {
            print("you are dead");
        }
    }
}