using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public UIManager UiManager;
    public float playerMoney;

    public void UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            Debug.Log("No te alcanza la plata");
            return;
            //Impide la compra
        }
        else
        {
            playerMoney += amount;
        }
    }
}
