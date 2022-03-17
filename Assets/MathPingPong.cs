using UnityEngine;

public class MathPingPong : MonoBehaviour
{

    [SerializeField] Light myLight;



    void Update()
    {
        float x = Mathf.PingPong(Time.time, 20);

        gameObject.transform.position =
            new Vector3(x,
            gameObject.transform.position.y,
            gameObject.transform.position.z);



        // myLight.intensity = Mathf.PingPong(Time.time, 1);

        // sin (20) -> .35

    }
}
