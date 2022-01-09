using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector]
    public Transform player;

    [SerializeField] public int health;
    [SerializeField] public float speed;
    [SerializeField] public float timeBetweenAttacks;
    [SerializeField] public int damage;

    private void Start() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void TakeDamage(int damageAmount) 
    {
        health -= damageAmount;
        if (health <= 0) {
            Destroy(gameObject);
        }

    }

}
