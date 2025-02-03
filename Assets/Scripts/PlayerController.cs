using UnityEngine;

/// <summary>
/// This script handles the player functionality: changing button. The player needs any Collider2D attached that has the trigger flag checked, so it can be hit
/// by the arrows.
/// </summary>
public class PlayerController : MonoBehaviour {

    Rigidbody2D rb2d;
    
    [Header("Changing")]
    public KeyCode change = KeyCode.Space;
    public SpriteRenderer _playerSpriteRenderer;
    private int[] zRotation = new int[] {0,90,270,180}; // 180 doesnt work for up and left

    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
        _playerSpriteRenderer = GetComponent<SpriteRenderer>();
        RandomDirection();
    }

    void Update() {
        if (Input.GetKeyDown(change)) {
            Change();
        }
    }

    private void Change() {
        transform.Rotate(new Vector3(0,0,90));
        if (transform.rotation.eulerAngles.z == 90) {
            Debug.Log("left");
        } else if (transform.rotation.eulerAngles.z == 270) {
            Debug.Log("right");
        } else if (transform.rotation.eulerAngles.z == 0) {
            Debug.Log("up");
        } else if (transform.rotation.eulerAngles.z == 180) {
            Debug.Log("down");
        }
    }

    private void RandomDirection() {
        _playerSpriteRenderer.transform.Rotate(new Vector3(0,0,zRotation[Random.Range(0,2)]));
    }
}

