using UnityEngine;
using System.Collections;

public class Bottle : MonoBehaviour
{


    Vector2 touchDeltaPosition;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //    if ( Input.GetTouch(0).phase == TouchPhase.Moved) {



        //        Debug.Log("aaaaa");
        //        // Get movement of the finger since last frame
        //        touchDeltaPosition = Input.GetTouch(0).deltaPosition;

        //        // Move object across XY plane
        //        transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
        //    }
        //    Debug.Log(Input.touchCount);


        if (Input.touchCount > 0)
        {
            Debug.Log("asdasdas");

        }
        

    }
}

