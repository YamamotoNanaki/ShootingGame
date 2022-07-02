using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFixedShot : MonoBehaviour
{
    GameObject player;
    public GameObject bullet;
    public int bulletWayNum = 3;
    public float bulletWaySpace = 30;
    public float bulletWayAxis = 180;
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
        GameObject bulletclone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletclone.GetComponent<EnemyBullet>();
        bulletObject.SetCharcterObject(gameObject);
        bulletObject.SetForwardAxis(Quaternion.AngleAxis(axis, Vector3.up));
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) player = GameObject.FindGameObjectWithTag("Player");
        nowTimer -= Time.deltaTime;
        if (nowTimer <= 0)
        {
            float bulletWaySpaceSplit = 0;
            for (int i = 0; i < bulletWayNum; i++)
            {
                CreateShotObject(bulletWaySpace - bulletWaySpaceSplit + bulletWayAxis - transform.localEulerAngles.y);
                bulletWaySpaceSplit += (bulletWaySpace / (bulletWayNum - 1)) * 2;
            }
            nowTimer = time;
        }
    }
}
