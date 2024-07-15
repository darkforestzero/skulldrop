using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ProgressBar : MonoBehaviour
{
    [SerializeField]
    private GameObject fill;
    [SerializeField]
    private GameObject backing;
    [SerializeField]
    private float startingProgress = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetProgress(float progress)
    {
        Assert.IsTrue(progress >= 0 && progress <= 1);
        fill.transform.localScale = new Vector3(progress, 1, 1);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
