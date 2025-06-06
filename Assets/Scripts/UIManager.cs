using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TxtMoney;
    public DineroManager dineroManager;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        TxtMoney.text = ("Tu dinero es: "+ dineroManager.playerMoney.ToString()) ;
    }
}
