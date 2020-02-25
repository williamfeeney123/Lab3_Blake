using UnityEngine;

public class LazerMove : MonoBehaviour
{
    public float SceneWidth = 5f;

    private float speed = 0.02f;

    void Update()
    {

      

        Vector2 newPosition = new Vector2(transform.position.x + speed, transform.position.y);

        if (newPosition.x > SceneWidth)
        {
            speed = -0.02f; //Move left.
        }
        else if (newPosition.x < -SceneWidth)
        {
            speed = 0.02f; //Move right.
        }


        transform.position = newPosition;


    }
}
