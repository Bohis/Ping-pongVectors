using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour {
    public InputAction input;

    public string keyUp;
    public string keyDown;

    private void Start() {
        input = new InputAction();

        input.AddCompositeBinding("Axis")
            .With("Positive", $"<keyboard>/{keyUp}")
            .With("Negative", $"<keyboard>/{keyDown}");
        input.AddCompositeBinding("Axis(whichSideWins=1)");

        input.Enable();
    }
}