using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyPlant : MonoBehaviour {

    public int health;

    private Animator anim;
    public GameObject bloodEffect;

    Rigidbody2D rb;
    GameObject target;
    float moveSpeed;
    Vector3 directionToTarget;

    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = Random.Range(1f, 2f);
    }

    void Update()
    {
        PlantMove();
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }


        //transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damage taken");
    }
    void PlantMove()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed,
                                        directionToTarget.y * moveSpeed);
        }
        else
            rb.velocity = Vector3.zero;
    }
}
