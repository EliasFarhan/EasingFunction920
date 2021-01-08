using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothStopManager : MonoBehaviour
{
    [SerializeField] private Transform[] circles;

    private float t = 0.0f;
    private const float movingPeriod = 1.0f;
    private const float pausePeriod = 1.0f;

    private const float minX = -5.0f;
    private const float maxX = 5.0f;

    private float[] positions;
    // Start is called before the first frame update
    void Start()
    {
        positions = new float[circles.Length];
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > movingPeriod + pausePeriod)
        {
            t -= movingPeriod + pausePeriod;
        }

        if (t < movingPeriod)
        {
            positions[0] = Easing.Linear(t);
            positions[1] = Easing.SmoothStop2(t);
            positions[2] = Easing.SmoothStop3(t);
            positions[3] = Easing.SmoothStop4(t);
            positions[4] = Easing.SmoothStop5(t);
            const float length = maxX - minX;
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i].localPosition = new Vector3(
                    length * positions[i] + minX,
                    circles[i].localPosition.y,
                    circles[i].localPosition.z);
            }
        }

        if (t > movingPeriod)
        {
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i].localPosition = new Vector3(
                    maxX,
                    circles[i].localPosition.y,
                    circles[i].localPosition.z);
            }
        }
    }
}
