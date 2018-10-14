using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour {

    public GameObject AchievementsPanel;
    public Text finalscore, finalhighscore;
    public Text timecounter;
    int time = 20;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Startcounter", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (time < 0)
        {
            ScoreManager.gameended = true;
            PlayerController.canmove = false;
            PigSpawner.cangeneratepigs = false;
            CancelInvoke("Startcounter");
            AchievementsPanel.SetActive(true);
            finalscore.text = ScoreManager.slaughteredpigs.ToString();
            finalhighscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();

        }
	}

    void Startcounter()
    {
        timecounter.text = time.ToString();
        time--;
    }
}
