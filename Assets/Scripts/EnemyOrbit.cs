using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyOrbit : MonoBehaviour
{
    public Transform enemy, player;
    public Vector2 enemyPos, playerPos, direction, perpendicular;


    private void Start()
    {
        player.position = new Vector2(0, 0);

    }

    private void Update()
    {
        float speed = 1f;
        enemyPos = transform.position;
        playerPos = player.position;
        direction = playerPos - enemyPos;
        perpendicular = Vector2.Perpendicular(direction);
        Vector2.MoveTowards(enemyPos, perpendicular, speed * Time.deltaTime);
    }
}
