using UnityEngine;

public class MathSingScript : MonoBehaviour
{
    void Update()
    {


        // 1
        float x = 10 + Mathf.Sin(Time.time * 4) * 10; // -1 -> 1


        gameObject.transform.position =
                    new Vector3(x,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z);

    }
}
