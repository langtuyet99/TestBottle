using UnityEngine;
using System.Collections;

public class SplashScrip : MonoBehaviour {
    public float timeDelay;
	// Use this for initialization
	IEnumerator Start () {

        yield return new WaitForSeconds(timeDelay);
        Application.LoadLevel("Menu");

    }
	

}
