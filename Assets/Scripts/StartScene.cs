using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject instruction;
    public void PlayGame() {
        // Debug.Log("enter play scene");
        SceneManager.LoadScene(1);

    }

    public void Instruction() {
        if (instruction.activeSelf) {
            instruction.SetActive(false);
        } else {
            instruction.SetActive(true);
        }
    }
}
