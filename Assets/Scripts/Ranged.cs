using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranged : Enemy
{
    public float stopDistance;
    private float attackTime;
    private Animator animate;
    public Transform shotPoint;
    public GameObject enemyProjectile;

    public override void Start() 
    {
        base.Start();
        animate = GetComponent<Animator>();
    }

    private void Update() 
    {
        if (player != null) {
            if (Vector2.Distance(transform.position, player.position) > stopDistance) {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }

            if (Time.time >= attackTime) {
                attackTime = Time.time + timeBetweenAttacks;
                animate.SetTrigger("attack");
            }
        }
    } 

    public void RangedAttack()
    {
        Vector2 direction = player.position - shotPoint.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + 90, Vector3.forward);
        shotPoint.rotation = rotation;

        Instantiate(enemyProjectile, shotPoint.position, shotPoint.rotation);
    }
}
