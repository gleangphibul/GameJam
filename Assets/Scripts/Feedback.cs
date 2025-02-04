using UnityEngine;

public class Feedback : MonoBehaviour
{

    public GameObject feedbackPrefab;

    private float _currentTimer;

    public float feedbackTimer = 1;        // 1 second


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _currentTimer += Time.deltaTime;
        if (_currentTimer >= feedbackTimer) {
            Destroy(feedbackPrefab);
            _currentTimer = 0;
        }
    }
}
