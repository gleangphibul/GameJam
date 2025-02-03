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

    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("collision!");

        float arrowDir = -1;
        if (other.gameObject.CompareTag("Up")) {
            arrowDir = 0;
        } else if (other.gameObject.CompareTag("Left")) {
            arrowDir = 90;
        } else if (other.gameObject.CompareTag("Down")) {
            arrowDir = 180; 
        } else if (other.gameObject.CompareTag("Right")) {
            arrowDir = 270;
        }

        Debug.LogFormat("playerDir: {0}   //   arrowDir: {1}", playerDir, arrowDir);
        if (Mathf.Abs(arrowDir - playerDir) == 180) {
            Debug.Log("match!");
        }
        else {
            Debug.Log("no match :(");
        }
        other.gameObject.GetComponent<Arrow>().Disappear();
    }
}
