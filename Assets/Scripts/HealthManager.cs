using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public UIManager UiManager;
    public float playerHealth;

    public bool UpdateHealth(float amount)
    {

        if (playerHealth + amount < 0)
        {
            Debug.Log("You are dead xd");
            //Impide la compra
            return false;
        }
        else
        {
            playerHealth += amount;
            return true;
        }
    }
}
