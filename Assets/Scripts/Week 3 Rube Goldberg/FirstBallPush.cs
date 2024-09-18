using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBallPush : MonoBehaviour
{
    public GameObject spawnedPrefab;
    public Transform spawnLocation;
    

    public float timerCountingDown = 5f;
    public float timerDuration = 0f;

    public bool isCountingDown = true;

    public float ballSpeed = 500f; 

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
         if(isCountingDown == true)
        {
            timerCountingDown -= Time.deltaTime;
        }
        


        if(timerCountingDown <= timerDuration)
        {
            Debug.Log("Go!");
            timerCountingDown = 0f;

            isCountingDown = false;
            enabled = false;

            SpawnBall();
        }
    }

    

    public void SpawnBall()
    {
        GameObject ball = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);
        ball.GetComponent<Rigidbody>().AddForce(ball.transform.forward * ballSpeed);
    }
}
