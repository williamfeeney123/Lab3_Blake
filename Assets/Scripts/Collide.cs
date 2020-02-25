using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Make sure to add this for access to the SceneManagment class.
using UnityEngine.UI;

public class Collide : MonoBehaviour
{
    public GameObject Chad;
    public GameObject Chad2;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject == Chad)
        {

            SceneManager.LoadScene(2);


        }

        if (collision.collider.gameObject == Chad2)
        {

            SceneManager.LoadScene(3);


        }



    }
}
