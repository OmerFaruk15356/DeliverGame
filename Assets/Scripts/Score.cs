using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] float score = 0;
    float time;
    float point;

    Package package;

    private void Start()
    {
        package = GetComponent<Package>();
        CalculateScore();
    }
    private void Update()
    {
        CalculateTime();
    }

    public void CalculateTime()
    {
        if (package.hasPackage)
        {
            time += Time.deltaTime;
            Debug.Log(time);
        }

    }

    public void CalculateScore()
    {
        if (package.deliverComplete)
        {
            point = Mathf.RoundToInt(20 - time);

            score += point;
        }

        time = 0;
    }

}
