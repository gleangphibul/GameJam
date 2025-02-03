using UnityEngine;


// this script will be attached to the player sprite
public class ArrowMatching : MonoBehaviour
{

    // variable that contains the direction that the player's arrow is oriented
    private float playerDir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        // playerDir = GetComponent<PlayerController>().direction;
        playerDir = transform.rotation.eulerAngles.z;       // 0 -> up, 90 -> left, 180 -> down, 270 -> right
    }

    void OnTriggerEnter2D (Collider2D other)
	{
		Arrow arrow = other.GetComponent<Arrow>();
		if (arrow != null) {
            float arrowDir = arrow.transform.rotation.eulerAngles.z; 
            if (Mathf.Abs(arrowDir-playerDir)==180) {
                Debug.Log("match!");
            } else {
                Debug.Log("no match :(");
            }
			arrow.Disappear();                          // TODO make arrow disappear - check how this is actually named in arrow script
		}
	}
}
