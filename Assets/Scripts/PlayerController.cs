using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    Vector3 position;
    Rigidbody rb;
    float horizontal;
    float speed = 8.0f;
    public Text scoreboard;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 position = rb.position;
        position.x = position.x + horizontal * Time.fixedDeltaTime * speed;
        position.x = Mathf.Clamp(position.x, -9, 9);
        rb.MovePosition(position);
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Rock")
        {
            score++;
        }
        else if (collision.gameObject.tag == "Meteorite") {
            speed = speed * 0.5f;
            StartCoroutine(SpeedUp());
        }

        else if (collision.gameObject.tag == "Power")
        {
            transform.localScale = new Vector3(4, 1, 1);
            speed = speed * 1.5f;
            StartCoroutine(ShrinkPlayer());
        }
        Destroy(collision.gameObject);
        scoreboard.text = score.ToString();
    }

    IEnumerator ShrinkPlayer()
    {
        yield return new WaitForSeconds(6);
        transform.localScale = new Vector3(2, 1, 1);
        speed = speed / 1.5f;
    }
    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(5);
        speed = speed / 0.5f;
    }
}
