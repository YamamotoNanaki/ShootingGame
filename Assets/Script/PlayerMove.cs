using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedSlow = 0.01f;
    public float speedFast = 0.025f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.03f;
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.V)) speed = speedSlow;
        else speed = speedFast;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) pos.x += speed;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) pos.x -= speed;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) pos.z += speed;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) pos.z -= speed;

        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
