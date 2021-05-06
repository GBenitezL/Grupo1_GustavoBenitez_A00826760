using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeCounter : MonoBehaviour
{
    Vector3 position;
    Rigidbody rb;
    public Text LifeCount;
    int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LifeCount.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rock") {
            lives--;
            LifeCount.text = lives.ToString();
        }
        if (lives == 0)
            SceneManager.LoadScene("PlayAgain");
    }
}
