using UnityEngine;

public class MathLedrpScript : MonoBehaviour
{

    float t = 0f;
    bool goBackwards = false;


    void Update()
    {
        // min, max, fraction (0 -> 1)
        float xPos = Mathf.SmoothStep(0, 20, t); // .005

        gameObject.transform.position =
            new Vector3(xPos,
            gameObject.transform.position.y,
            gameObject.transform.position.z);

        if (t >= 1)
            goBackwards = true;
        else if (t <= 0)
            goBackwards = false;



        if (!goBackwards)
            t += Time.deltaTime;
        else
            t -= Time.deltaTime;
    }
}
