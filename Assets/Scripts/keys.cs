using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour
{
    public float distancefromcenter = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        // set timer to destroy after 10 seconds
        Destroy(gameObject, 10);
    }
    // on click spawn a ball at the top of the screen in the x coord of click
    void OnMouseDown()
    {
    }
    // Update is called once per frame
    void Update()
    {



    }

}
