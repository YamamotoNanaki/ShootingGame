using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{

    GameObject[] enemy;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemy.Length == 0) panel.SetActive(true);   
    }
}
