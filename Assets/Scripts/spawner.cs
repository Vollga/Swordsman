using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject gObject;
    public int rate;
    public int rateIncrease;


	// Use this for initialization
	void Start () {
        
        InvokeRepeating("EnemySpawnFirstWave", Random.Range(0, rate+3), rate);

    }

    void EnemySpawnFirstWave()
    {
        Instantiate(gObject,transform);
        if (Time.time > 30)
        {
            CancelInvoke("EnemySpawnFirstWave");
            rate = rate - rateIncrease;
            InvokeRepeating("EnemySpawnSecondWave", Random.Range(0, rate+3), rate);
        }
    }

    void EnemySpawnSecondWave()
    {
        Instantiate(gObject, transform);
        if (Time.time > 60)
        {
            CancelInvoke("EnemySpawnSecondWave");
            rate = rate - rateIncrease;
            InvokeRepeating("EnemySpawnThirdWave", Random.Range(0, rate+3), rate);
        }
    }

    void EnemySpawnThirdWave()
    {
        Instantiate(gObject, transform);
    }
}
