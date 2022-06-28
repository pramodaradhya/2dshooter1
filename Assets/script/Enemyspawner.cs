using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{

    public Transform LeftScreenIdentifier;
    public Transform RightScreenIdentifier;
    public GameObject Enemy;
    public float spawnEveryXSeconds;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3.0f, spawnEveryXSeconds);
    }

    void Spawn()
    {
        float xPos = Random.Range(LeftScreenIdentifier.position.x, RightScreenIdentifier.position.x);
        float yPos = Random.Range(LeftScreenIdentifier.position.y, RightScreenIdentifier.position.y);

        Vector2 spawnPos = new Vector2(xPos, yPos);

        Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
    }
}
