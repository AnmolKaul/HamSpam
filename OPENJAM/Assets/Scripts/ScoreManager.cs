using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text pigslaughtered;
    public static int slaughteredpigs;
    public static bool gameended;
    // Use this for initialization
    private void Awake()
    {
        gameended = false;
    }
    void Start ()
    {
        slaughteredpigs = 0;
        //pigslaughtered.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        pigslaughtered.text = "0";
    }

    public void Incrementscore()
    {
        if (gameended == false)
        {
            slaughteredpigs += 1;
            pigslaughtered.text = slaughteredpigs.ToString();
            if (slaughteredpigs > PlayerPrefs.GetInt("Highscore", 0))
            {
                //Playerprefs
                PlayerPrefs.SetInt("Highscore", slaughteredpigs);
            }
        }
    }

}
