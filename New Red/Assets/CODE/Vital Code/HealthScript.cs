using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public RectTransform BarTransform;
    public float max_health = 500f;
    public float cur_health;
    public bool alive = true;
    private Transform player;
    private Transform respawnPoint;

    float minDelta = (float) 0.1;
    float maxDelta = 3;
    
    void Start()
    {
        
        alive = true;
        cur_health = max_health;
        SetHealthBar();
    }

    public void TakeDamage(float amount)
    {
        if (!alive) return;
        if (cur_health <= 0)
        {
            cur_health = 0;
            alive = false; 
        }
        
        cur_health -= amount;
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        float barRatio = minDelta + (maxDelta - minDelta) * Mathf.Clamp(cur_health / max_health, 0f, 1f);
        BarTransform.sizeDelta = new Vector2(barRatio, BarTransform.sizeDelta.y);
    }
}
//Learned to code health bar from youtube tutorials by ComputerGraphics.com
//The "Creating a 3D game with Health Damage" lessons. 