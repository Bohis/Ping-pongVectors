using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour {
    private PlayerControls controls;
    private Vector3 vectorStop;
    private Vector3 vectorMove;

    public float speed = 5;
    public Vector3 a;
    public Vector3 b;

    public float angleReflect;

    private void Awake() {
        controls = GetComponent<PlayerControls>();
    }

    private void FixedUpdate() {
        vectorMove = new Vector3(0, controls.input.ReadValue<float>(), 0);

        if (vectorStop == vectorMove) {
            return;
        }

        transform.position += vectorMove * speed * Time.fixedDeltaTime;
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, Vectors.VectorMultiplication(a, b));
        Gizmos.color = Color.black;
        Gizmos.DrawRay(transform.position, vectorMove);
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Wall") {
            vectorStop = vectorMove;
        }
        else if (collision.gameObject.tag == "Ball") {
            Vector3 normal = Vectors.VectorMultiplication(a, b);
            Ball ball = collision.GetComponent<Ball>();

            if (Vectors.Angle(-normal, ball.direction) > angleReflect) {
                return;
            }

            Vector3 reflection = Vectors.Reflect(ball.direction, normal);
            ball.direction = (reflection + vectorMove + normal).normalized;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Wall") {
            vectorStop = Vector3.zero;
        }
    }
}