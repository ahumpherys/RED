using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyONE : MonoBehaviour
{
    public float Speed = 50f;
    public float Damage = 10f;

    void Start() { }

    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        var health = other.gameObject.GetComponent<HealthScript>();
        if (health != null)
        health.TakeDamage(Damage);
    }
}
