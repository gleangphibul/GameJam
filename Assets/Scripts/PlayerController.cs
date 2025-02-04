using UnityEngine;

/// <summary>
/// This script handles the player functionality: changing direction.
/// </summary>
public class PlayerController : MonoBehaviour {
    public KeyCode change = KeyCode.Space;
    // private int[] zRotation = new int[] {0,90,270,180}; // 180 doesnt work for up and left

    void Start() {
    }

    void Update() {
        if (Input.GetKeyDown(change)) {
            Change(); // Change direction by 90 degrees to the left
        }
    }

    private void Change() {
        transform.Rotate(new Vector3(0,0,90));
        // if (transform.rotation.eulerAngles.z == 90) {
        //     Debug.Log("left");
        // } else if (transform.rotation.eulerAngles.z == 270) {
        //     Debug.Log("right");
        // } else if (transform.rotation.eulerAngles.z == 0) {
        //     Debug.Log("up");
        // } else if (transform.rotation.eulerAngles.z == 180) {
        //     Debug.Log("down");
        // }
    }
}

