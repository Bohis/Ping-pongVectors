using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public float speed;
    public Vector3 direction;

    private void Start() {
        Init();
    }

    private void Init() {
        float x = Random.value > 0.5 ? -1 : 1;
        float y = Random.value > 0.5 ? -1 : 1;
        direction = new Vector3(x, y, 0);
    }

    private void Move() {
        transform.position += direction * speed * Time.fixedDeltaTime;
    }

    private void FixedUpdate() {
        Move();
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, direction);
    }
}