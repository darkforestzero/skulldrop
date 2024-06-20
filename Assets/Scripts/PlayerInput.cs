using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput : MonoBehaviour
{
    public float distancefromcenter = 0.1f;
    public GameObject ball;
    private void SpawnBall(Vector3 position)
    {
        // create prefab 'ball' and set its position to x=0,y=5,z=1
        Instantiate(ball, new Vector3(position.x, 5, 1), Quaternion.identity);
    }

    void OnMouseDown()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        SpawnBall(new Vector3(mousePosition.x, mousePosition.y, 1));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if spacebar pressed, reset position to x=0,y=betwwen 0 and 10 on a sine over time,z=1
        // and reset velocity to 0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBall(new Vector3(Mathf.Sin(Time.time) * distancefromcenter, 5, 1));

            // transform.position = new Vector3(Mathf.Sin(Time.time) * distancefromcenter, 5, 1);
            // GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        // on enter reset the scene
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
