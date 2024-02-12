using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public int health;

    void Start()
    {
        health = 5;
    }

    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    public void Hurt(int damage)
    {
        health -= damage;
        Debug.Log("Health: " + health);
    }
}
