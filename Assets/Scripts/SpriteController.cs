using UnityEngine;

public class SpriteController : MonoBehaviour
{
    SpriteRenderer _buttonSpriteRenderer;

    public Sprite[] sprites;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _buttonSpriteRenderer = GetComponent<SpriteRenderer>();
        changeSprite();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeSprite() {

        int spriteNum = Random.Range(0,4);
        Debug.Log(spriteNum);

        if (spriteNum == 0) {
            _buttonSpriteRenderer.sprite = sprites[0];
        }
        if (spriteNum == 1) {
            _buttonSpriteRenderer.sprite = sprites[1];
        }
        if (spriteNum == 2) {
            _buttonSpriteRenderer.sprite = sprites[2];
        }
        if (spriteNum == 3) {
            _buttonSpriteRenderer.sprite = sprites[3];
        }
        if (spriteNum == 4) {
            _buttonSpriteRenderer.sprite = sprites[4];
        }

    }
}
