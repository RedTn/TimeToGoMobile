using UnityEngine;
using System.Collections;

public class UserInputHandler : MonoBehaviour {

    public delegate void TapAction(Touch t);
    public static event TapAction OnTap;

    public float tapMaxMovement = 50f;

    private Vector2 movement;

    private bool tapGestureFailed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];

            if(touch.phase == TouchPhase.Began)
            {
                movement = Vector2.zero;
            }
            else if(touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                
            }
        }
	}
}
