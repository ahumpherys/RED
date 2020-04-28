using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    public float Damage = 10f;
    private void OnTriggerEnter(Collider other)
    {
        var health = other.gameObject.GetComponent<HealthScript>();
        if (health != null)
            health.TakeDamage(Damage);
    }
}
