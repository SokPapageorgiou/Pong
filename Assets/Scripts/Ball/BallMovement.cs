using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class BallMovement : MonoBehaviour
{
    public BallStats ballStats;

    private Rigidbody2D _rigidbody;
    private Collider2D _collider2D;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider2D = GetComponent<Collider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = ballStats.VelocityVector();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        string obstacle = other.gameObject.tag;

        switch (obstacle)
        {
            case "Pads":
                BounceOnPads(other);
                break;
            
            case "Border":
                ballStats.InvertYDirection();
                break;
            
            case "Goal":
                StartCoroutine(Respawn());
                break;
        }
    }

    IEnumerator Respawn()
    {
        _collider2D.enabled = false;
        _spriteRenderer.enabled = false;
        yield return new WaitForSeconds(ballStats.TimeToRespawn);
        transform.position = ballStats.InitialPosition;
        _collider2D.enabled = true;
        _spriteRenderer.enabled = true;

    }

    private void BounceOnPads(Collision2D other)
    {
        float distanceX = transform.position.x - other.transform.position.x;
        bool invertX = Math.Abs(distanceX) > ballStats.ThresholdVerticalDistance;
        ballStats.InvertDirection(invertX);
    }
}
