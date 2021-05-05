using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject element;
    float speed = 4.0f;
    Vector3 position;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;
        
        if (gameObject.tag == "Rock")
            position += Vector3.down * speed * Time.deltaTime;
        else
            position += Vector3.down * 2 * speed * Time.deltaTime;
            
        transform.position = position;
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}
