using UnityEngine;


// this script will be attached to the player sprite
public class ArrowMatching : MonoBehaviour
{

    // variable that contains the direction that the player's arrow is oriented
    private float playerDir;

    [Header("Match Prefabs")]
    public GameObject[] matchPrefabs;

    [Header("Miss Prefabs")]
    public GameObject[] missPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {
        playerDir = transform.rotation.eulerAngles.z;       // 0 -> up, 90 -> left, 180 -> down, 270 -> right
    }

    void OnTriggerEnter2D(Collider2D other) {
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
            MatchFeedback();
        }
        else {
            Debug.Log("no match :(");
            MissFeedback();
            // timer.Stop()?
        }
        other.gameObject.GetComponent<Arrow>().Disappear();
    }

    private void MatchFeedback() {
        int randomIndex = Random.Range(0, matchPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-4, -4, 0);

        GameObject match = Instantiate(matchPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }

    private void MissFeedback() {
        int randomIndex = Random.Range(0, missPrefabs.Length);
        Vector3 spawnPosition = new Vector3(4, -4, 0);

        GameObject miss = Instantiate(missPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }

}
