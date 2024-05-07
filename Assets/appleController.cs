using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleController : MonoBehaviour
{
    appleScore main;
    Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        main = GameObject.Find("scripts").GetComponent<appleScore>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tr.position -= new Vector3(0f, 4f, 0f);

        if (tr.position.y < -7f)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Handle")
        {
            Destroy(this.gameObject);
            main.ScoreAdd();
        }    
    }


}
