using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    public float time = 1;
    public float delayTime = 1;
    float nowTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (nowTime > 0) nowTime -= Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && nowTime <= 0)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            nowTime = time;
        }
    }
}
