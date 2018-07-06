using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour {
    [SerializeField]
    Direction direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseDown() 
    {
        switch (direction)
        { 
            case Direction.NEXT:
                //call Next method
                Debug.Log("Pressed Next key");
                break;
            case Direction.PREVIOUS:
                //call previous method
                Debug.Log("Pressed previous key");
                break;
            default:
                //call default code
                Debug.Log("nothing is happening");
                break;
        }
    }
    public enum Direction
    {
        NEXT,
        PREVIOUS
    }
}
