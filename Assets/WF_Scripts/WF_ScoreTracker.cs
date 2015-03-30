using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WF_ScoreTracker : MonoBehaviour {

    public static float score;
    public Text scoretext;

    private float maxscore;

	// Use this for initialization
	void Start () 
    {
	    if(Application.loadedLevel == 0)
        {
            score = 0;
            maxscore = score;
        }
        if (Application.loadedLevel == 1)
        {
            score = 50;
            maxscore = score;
        }
        if (Application.loadedLevel == 2)
        {
            score = 0;
            maxscore = score;
        }
        if (Application.loadedLevel == 3)
        {
            score = 0;
            maxscore = score;
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
        scoretext.text = "Score: " + (score / maxscore).ToString("#0.##%");
	}
}
