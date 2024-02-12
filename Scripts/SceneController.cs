using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
private GameObject enemy;

    void Update()
    {
        if(enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
        float randomHeight = Random.Range(1.0f, 3.0f); //random height
        enemy.transform.localScale = new Vector3(1, randomHeight, 1);
        float angle = Random.Range(0, 360); //random angle
        enemy.transform.Rotate(0, angle, 0);

        Renderer renderer = enemy.GetComponent<Renderer>(); //random color
        if (renderer != null)
        {
            renderer.material.color = Random.ColorHSV();
        }
        }
    }
}