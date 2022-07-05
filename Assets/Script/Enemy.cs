using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyHP;
    public GManager gManager;
    // Start is called before the first frame update
    void Start()
    {
        enemyHP = 20;
        GameObject gameObject = GameObject.Find("GameManager");
        gManager = gameObject.GetComponent<GManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHP <= 0)
        {
            Destroy(this.gameObject);
            gManager.Score();
        }
    }

    public void Damage()
    {
        enemyHP--;
    }
}
