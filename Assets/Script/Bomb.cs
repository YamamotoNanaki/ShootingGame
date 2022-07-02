using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject[] enemyBulletObject = GameObject.FindGameObjectsWithTag("EnemyBullet");

            for (int i = 0; i < enemyBulletObject.Length; i++) Destroy(enemyBulletObject[i].gameObject);

            Instantiate(particle, Vector3.zero, Quaternion.identity);
        }
    }
}
