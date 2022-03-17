using UnityEngine;

public class Mathf_Generic : MonoBehaviour
{
    float epsilon = Mathf.Epsilon;
    float infinity = Mathf.Infinity;
    float negInfinity = Mathf.NegativeInfinity;


    // premiter of a circle
    float premiter = 2.0f * Mathf.PI * 5;


    float deg = 1.4f * Mathf.Rad2Deg;
    float rad = 65f * Mathf.Deg2Rad;

    // sin and cos ->

    float acos = Mathf.Acos(0.5f); // -> 60
    float asin = Mathf.Asin(0.5f); // -> 30
    float atan = Mathf.Atan(0.5f); // -> 26.56

    float sign = Mathf.Sign(-10);

    float round = Mathf.Round(10.2f);

    int rountInt = Mathf.RoundToInt(10.2f);




    float ceilFloat = Mathf.Ceil(10.2f);
    float ceilInt = Mathf.CeilToInt(10.2f);

    float floorFloat = Mathf.Floor(10.2f);
    float floorInt = Mathf.FloorToInt(10.2f);


    // 90, 390
    float deltaAgnel = Mathf.DeltaAngle(90, 390);


    float max = Mathf.Max(1.2f, 6.7f);
    float min = Mathf.Min(1.2f, 6.7f);

    float pow = Mathf.Pow(1.2f, 6.7f);

    float abs = Mathf.Abs(-10.5f); // 10.5



    float repeat = Mathf.Repeat(Time.time, 3); //

    /**
     *  Time.time % 3 -> 
     * 
     */

    // angle of each side -> 180 - (360 / n)
    // size of each side -> decide





    private void Start()
    {
        if (Mathf.Approximately (1.0f, 10.0f / 10.0f))
        {
        }



        float x = 10;

        float clampedX = Mathf.Clamp(x, 0, 20);
        float clampedNormal = Mathf.Clamp01(x);




        

    }









    /** 180  
     */

}
