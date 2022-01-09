using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public int health;

    public void TakeDamage(int damageAmount) 
    {
        health -= damageAmount;
        
        if (health <= 0) {
            Destroy(gameObject);
        }

    }

}
