using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleV : MonoBehaviour {
    public Transform point1;
    public Transform point2;
    public Text textAngle;
    public Text textScalar;

    private float angle;
    private float scalar;
    private LineRenderer lineRenderer;

    private void Awake() {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate() {
        angle = Vectors.Angle(point1.position, point2.position);
        scalar = Vectors.Scalar(point1.position, point2.position);

        lineRenderer.SetPosition(0, point1.position);
        lineRenderer.SetPosition(1, transform.position);
        lineRenderer.SetPosition(2, point2.position);

        textAngle.text = $"angle = {System.Math.Round(angle, 2)}";
        textScalar.text = $"scalar = {System.Math.Round(scalar, 2)}";
    }
}