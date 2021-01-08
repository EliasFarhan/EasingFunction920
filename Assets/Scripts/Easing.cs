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

    public static float FlipY(float t)
    {
        return 1.0f - t;
    }
    
    public static float SmoothStop2(float t)
    {
        float inverseT = 1.0f - t;
        return 1.0f - inverseT * inverseT;
    }
    
    public static float SmoothStop3(float t)
    {
        float inverseT = 1.0f - t;
        return 1.0f - inverseT * inverseT * inverseT;
    }
    
    public static float SmoothStop4(float t)
    {
        float inverseT = 1.0f - t;
        return 1.0f - inverseT * inverseT * inverseT * inverseT;
    }
    
    public static float SmoothStop5(float t)
    {
        float inverseT = 1.0f - t;
        return 1.0f - inverseT * inverseT * inverseT * inverseT * inverseT;
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

    public static float Scale(float a, float t)
    {
        return  a * t;
    }

    public static float ReverseScale(float a, float t)
    {
        return (1.0f - t) * a;
    }

    public static float Arch2(float t)
    {
        return Scale(FlipY(t), t);
    }

    public static float SmoothStartArch3(float t)
    {
        return 20.0f/3.0f*Scale(Arch2(t), t);
    }

    public static float SmoothStopArch3(float t)
    {
        return 20.0f/3.0f*ReverseScale(Arch2(t), t);
    }
    
    public static float SmoothStepArch4(float t)
    {
        return 12.0f/5.0f*ReverseScale(SmoothStartArch3(t), t);
    }

    public static float BellCurve6(float t)
    {
        return 36.0f/25.0f*SmoothStopArch3(t) * SmoothStartArch3(t);
    }

    public static float NormalizedBezier3(float b, float c, float t)
    {
        float s = 1.0f - t;
        float t2 = t * t;
        float s2 = s * s;
        float t3 = t2 * t;
        return (3.0f * b * s2 * t) + (3.0f * c * s * t2) + t3;
    }
    
}
