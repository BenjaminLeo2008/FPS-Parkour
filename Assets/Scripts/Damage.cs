using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 10;
    public HealthManager healthManager;
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //restar precio al dinero del player
            healthManager.UpdateHealth(-damage);
            Destroy(gameObject);

        }
    }
}
