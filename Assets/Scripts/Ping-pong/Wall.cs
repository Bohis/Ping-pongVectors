using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Wall : MonoBehaviour {
    public Vector3 a;
    public Vector3 b;

    private Vector3 normal;

    private void Update() {
        normal = Vectors.VectorMultiplication(a, b);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, normal);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Ball") {
            Ball ball = collision.GetComponent<Ball>();

            Vector3 reflection = Vectors.Reflect(ball.direction, normal);
            ball.direction = reflection.normalized;
        }
    }
}