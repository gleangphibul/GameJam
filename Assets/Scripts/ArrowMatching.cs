using UnityEngine;
using UnityEngine.SceneManagement;


// this script will be attached to the player sprite
public class ArrowMatching : MonoBehaviour
{

    // variable that contains the direction that the player's arrow is oriented
    private float playerDir;
    private AudioSource cuttingSound;

    [Header("Match Prefabs")]
    public GameObject[] matchPrefabs;
    public GameObject timerObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cuttingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDir = transform.rotation.eulerAngles.z;       // 0 -> up, 90 -> left, 180 -> down, 270 -> right
    }

    void OnTriggerEnter2D(Collider2D other) {
        Timer newTimer = timerObject.GetComponent<Timer>();
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

        if (Mathf.Abs(arrowDir - playerDir) == 180) {
            
           MatchFeedback();
        }
        else {
            newTimer.stopTimer();
            SceneManager.LoadScene(2);
        }
        other.gameObject.GetComponent<Arrow>().Disappear();
    }

    private void MatchFeedback() {
        int randomIndex = Random.Range(0, matchPrefabs.Length);
        Vector3 spawnPosition = new Vector3(0, -4, 0);
        cuttingSound.Play();

        GameObject match = Instantiate(matchPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
