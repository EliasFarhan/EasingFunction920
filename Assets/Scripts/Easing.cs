using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easing : MonoBehaviour
{
    public static float Linear(float t)
    {
        return t;
    }
    
    public static float SmoothStart2(float t)
    {
        return t * t;
    }
    
    public static float SmoothStart3(float t)
    {
        return t * t * t;
    }
    
    public static float SmoothStart4(float t)
    {
        return t * t * t * t;
    }
    
    public static float SmoothStart5(float t)
    {
        return t * t * t * t * t;
    }

    public static float Flip(float t)
    {
        return 1.0f - t;
    }
    
    public static float SmoothStop2(float t)
    {
        float inverseT = 1.0f - t;
        return 1-0f-inverseT*inverseT;
    }
    
    public static float SmoothStop3(float t)
    {
        float inverseT = 1.0f - t;
        return 1-0f-inverseT*inverseT*inverseT;
    }
    
    public static float SmoothStop4(float t)
    {
        float inverseT = 1.0f - t;
        return 1-0f-inverseT*inverseT*inverseT*inverseT;
    }
    
    public static float SmoothStop5(float t)
    {
        float inverseT = 1.0f - t;
        return 1-0f-inverseT*inverseT*inverseT*inverseT*inverseT;
    }

    public static float SmoothStep(float t)
    {
        return t * t * (3.0f - 2.0f * t);
    }

    public static float SmootherStep(float t)
    {
        return t * t * t * (6.0f * t * t - 15.0f * t + 10.0f);
    }

    public static float Mix(float a, float b, float blend)
    {
        return (a + blend * (b - a));
    }
}
