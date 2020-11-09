using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerUp;
    public float maxTimer;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTimer) 
        {
            GameObject newPowerUp = Instantiate(powerUp);
            newPowerUp.transform.position = transform.position + new Vector3(Random.Range(-0.500f, 0.500f), 0, 0);
            Destroy(newPowerUp, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
