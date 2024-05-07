using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appleScore : MonoBehaviour
{
    public Text scoreboard;
    public int score;
    public Button boost;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        boost.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {        
        if (score == 5)
        {
            boost.gameObject.SetActive(true);
        }
        if (score == 0)
        {
            boost.gameObject.SetActive(false);
        }
    }

    public void ScoreAdd()
    {
        if (score < 5)
        {
            score++;
            scoreboard.text = score.ToString();
        }
    }

    public void ScoreRemove()
    {
        score = 0;
        scoreboard.text = score.ToString();
    }
}
