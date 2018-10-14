using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSpawner : MonoBehaviour {

    public Transform[] pigs;
    public GameObject pigprefab;
    float pigspawntime = 1f;
    AudioSource source;
    public static bool cangeneratepigs;

    // Use this for initialization
    private void Awake()
    {
        cangeneratepigs = true;
    }
    void Start () {
        InvokeRepeating("GeneratePig", 1f, pigspawntime);
        source = GetComponent<AudioSource>();
        Playsound();
	}

    void Playsound()
    {
        source.Play();
    }
   
    
    void GeneratePig()
    {
        if (cangeneratepigs == true)
        {

            for (int i = 0; i < Random.Range(1, pigs.Length); i++)
            {
                int rand = Random.Range(0, pigs.Length);
                Instantiate(pigprefab, pigs[rand].position, Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

        pigspawntime -= 0.009f;
        if (pigspawntime <= 0)
        {
            pigspawntime = 1f;
        }
	}
}
