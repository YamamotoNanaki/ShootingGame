using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForwardShot : MonoBehaviour
{
    GameObject player;
    public GameObject bullet;
    public float time = 1;
    public float delayTime = 1;
    float nowTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        nowTimer = delayTime;
    }

    void CreateShotObject(float axis)
    {
        var direction = player.transform.position - transform.position;
        direction.y = 0;
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        GameObject bulletclone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletclone.GetComponent<EnemyBullet>();
        bulletObject.SetCharcterObject(gameObject);
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) player = GameObject.FindGameObjectWithTag("Player");
        nowTimer -= Time.deltaTime;
        if (nowTimer <= 0)
        {
            CreateShotObject(-transform.localEulerAngles.y);
            nowTimer = time;
        }
    }
}
