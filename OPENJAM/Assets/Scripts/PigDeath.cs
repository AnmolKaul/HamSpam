using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigDeath : MonoBehaviour {

    // Use this for initialization
    public GameObject bloodprefab;
    public ScoreManager manager;
    void Start () {

        manager = GameObject.FindWithTag("scoremanager").GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
 

    private void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Saw"))
        {
            //Blood splatter and death sound
            Instantiate(bloodprefab, transform.position, Quaternion.identity);
            //Increment score
            manager.Incrementscore();
            //Kill the pig
            Destroy(gameObject);
        }
        else if (hit.CompareTag("PigCollider"))
        {
            Destroy(gameObject);
        }
    }
}
