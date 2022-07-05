using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    int enemyCount;
    GameObject[] enemy;

    public GameObject panel;
    public Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920,1080,false);
        Application.targetFrameRate = 60;
        panel.SetActive(false);
        enemyCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemy.Length == 0) panel.SetActive(true);
        if (Input.GetKey(KeyCode.Return))
        {
            string a = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(a);
        }
    }

    public void Score()
    {
        enemyCount++;
        textComponent.text = "Score : " + enemyCount;
    }
}
