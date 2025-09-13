using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrbit : MonoBehaviour
{
    public Transform player;
    public float speedMultiplier = 1f;
    public float minSpeed = 0.5f;
    public float maxSpeed = 5f;

    private void Update()
    {
        if (player == null) return;

        // Calculate distance to player
        float distance = Vector2.Distance(transform.position, player.position);

        // Calculate speed based on distance (clamped for stability)
        float speed = Mathf.Clamp(distance * speedMultiplier, minSpeed, maxSpeed);

        // Move perpendicularly to the player (tangent to the orbit)
        // If facing the player, transform.right is perpendicular
        transform.position += transform.right * speed * Time.deltaTime;
    }
}
