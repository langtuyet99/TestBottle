using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public static ButtonManager Instance;
    public Button spinNextButton;
    public Sprite spinImage;
    public Sprite nextTurnImage;
    Text spinNextText;
    // Use this for initialization
    void Start() {
        Instance = this;

        spinNextText = spinNextButton.transform.FindChild("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {

    }

   public void PlayNowButton()
    {
        Application.LoadLevel("SpinBottle");
    }

    public void MoreButton()
    {
        Application.LoadLevel("More");
    }
    public void MailButton()
    {
        Debug.Log("MailButton");
    }
    public void SettingButton()
    {
        Debug.Log("SettingButton");
    }
    public void FacebookButton()
    {
        Debug.Log("FacebookButton");
    }
    public void InfoButton()
    {
        Debug.Log("InfoButton");
    }

    public void SpinNextTurnButton()
    {
        if (Bottle.Instance.gameState == GameState.STOP)
        {
            Bottle.Instance.gameState = GameState.READY;
            ChangeSpriteButton();
           // spinNextButton.image.sprite = spinImage;
            //Debug.Log("Ready");
            return;
        }
        if (Bottle.Instance.gameState == GameState.READY)
        {
            Bottle.Instance.gameState = GameState.SPINNING;
            ChangeSpriteButton();
            //spinNextButton.image.sprite = nextTurnImage;
            //Debug.Log("Spin");
            return;
        }
    }

    public void ChangeSpriteButton()
    {
        if (Bottle.Instance.gameState == GameState.READY)
        {
            spinNextText.text= "Spin";
            spinNextButton.image.sprite = spinImage;
        }
        if (Bottle.Instance.gameState == GameState.STOP)
        {
            spinNextText.text= "Next Turn";
            spinNextButton.image.sprite = nextTurnImage;
        }
    }
}
