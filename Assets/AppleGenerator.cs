using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour
{
    float timer = 2;
    public GameObject gm;
    public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(gm, parent/*, new Vector3(0f, 230f, 0.1f), new Quaternion(0, 0, 0, 0)*/);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;            
        }
        else
        {
            float pos_x = Random.Range(350.0f, 900.0f);

            Instantiate(gm, new Vector3(pos_x, 500f, 0.1f), new Quaternion(0, 0, 0, 0), parent);

            timer = 2f;
        }
        


    }
}
