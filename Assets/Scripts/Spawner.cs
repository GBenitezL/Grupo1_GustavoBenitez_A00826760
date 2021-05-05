using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject rock, power;
    int cont = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (cont < 15)
            {
                Instantiate(rock, new Vector3(Random.Range(-8f, 8f), 6, 0), transform.rotation);
                cont++;
            }
            else
            {
                Instantiate(power, new Vector3(Random.Range(-8f, 8f), 6, 0), transform.rotation);
                cont = 0;
            }
        }
    }
}
