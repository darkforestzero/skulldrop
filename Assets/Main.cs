using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject[] lanes;

    //every 2 seconds pick a random lane to call it's component "ScoringLane"'s function ActivateHighlight()
    // and call DeActivateHighlight() on all other lanes
    void ActivateRandomLane()
    {
        int randomLane = Random.Range(0, lanes.Length);
        for (int i = 0; i < lanes.Length; i++)
        {
            if (i == randomLane)
            {
                lanes[i].GetComponent<ScoringLane>().ActivateHighlight();
            }
            else
            {
                lanes[i].GetComponent<ScoringLane>().DeActivateHighlight();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //call ActivateRandomLane() every 2 seconds
        InvokeRepeating("ActivateRandomLane", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
