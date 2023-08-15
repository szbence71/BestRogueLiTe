using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    public Sprite[] frames;
    private SpriteRenderer _renderer;

    public int frame = 0;

    private void Awake() {
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void LateUpdate() {
        _renderer.sprite = frames[frame];
    }
}
