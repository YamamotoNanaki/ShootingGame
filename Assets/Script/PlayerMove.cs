using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedSlow = 0.25f;
    public float speedFast = 1;
    Vector3 leftBottom;
    Vector3 rightTop;
    float left, right, top, bottom;
    // Start is called before the first frame update
    void Start()
    {
        var distance = Vector3.Distance(Camera.main.transform.position, leftBottom);
        leftBottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
        rightTop = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, distance));
        foreach (Transform child in gameObject.transform)
        {
            if (child.localPosition.x >= right) right = child.transform.localPosition.x;
            if (child.localPosition.x <= left) left = child.transform.localPosition.x;
            if (child.localPosition.z >= top) top = child.transform.localPosition.z;
            if (child.localPosition.z <= bottom) bottom = child.transform.localPosition.z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float speed;
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.V)) speed = speedSlow;
        else speed = speedFast;
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) pos.x += speed;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) pos.x -= speed;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) pos.z += speed;
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) pos.z -= speed;

        transform.position = new Vector3(Mathf.Clamp(pos.x, leftBottom.x + transform.localScale.x - left, rightTop.x - transform.localScale.x - right),
            pos.y, Mathf.Clamp(pos.z, leftBottom.z + transform.localScale.z - bottom, rightTop.z - transform.localScale.z - top));
    }
}
