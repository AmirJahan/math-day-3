
using UnityEngine;

public class MathMoveTowards : MonoBehaviour
{

    [SerializeField] float speed = 1.0f;

    void Update()
    {
        float x = Mathf.MoveTowards(
            gameObject.transform.position.x,
            20,
            Time.deltaTime * speed);


        gameObject.transform.position =
                    new Vector3(x,
                    gameObject.transform.position.y,
                    gameObject.transform.position.z);

    }
}
