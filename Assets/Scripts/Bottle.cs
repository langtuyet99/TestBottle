using UnityEngine;
using System.Collections;


public class Bottle : MonoBehaviour
{


    public static Bottle Instance;
    public GameState gameState; // trang thai chai
    [SerializeField]bool isMaxSpeed;
    bool spinning;          // kiem tra dang quay
    int randomMaxSpeed;    //
    Vector2 touchDeltaPosition;
    public float speed;
    // Use this for initialization
    void Start()
    {
        Instance = this;
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
        if (gameState == GameState.READY)
        {
            randomMaxSpeed = Random.Range(2000, 5000);
            spinning = true;
            isMaxSpeed = false;
            speed = 0;
        }

        if (spinning && gameState ==GameState.SPINNING)
        {
            if (speed < 0)
            {
                gameState = GameState.STOP;
                spinning = false;
                speed = 0;
                ButtonManager.Instance.ChangeSpriteButton();
            }
            else if (speed <= randomMaxSpeed && !isMaxSpeed)
            {
                speed += 20;
            }
            else
           if (speed > randomMaxSpeed)
            {
                isMaxSpeed = true;
            }
            if (isMaxSpeed)
            {
                speed -= 10;
            }

            this.transform.Rotate(new Vector3(0, 0, this.transform.rotation.z + Time.deltaTime * speed));
        }
    }
}

public enum GameState
{
    READY,
    SPINNING,
    STOP
}

