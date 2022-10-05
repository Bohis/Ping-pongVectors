using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Reflection : MonoBehaviour {
    private LineRenderer lineRenderer;

    public Transform start;
    public Transform end;
    public Text text;

    public Vector3 vector1;
    public Vector3 vector2;

    private void Awake() {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 5;
    }

    private void Update() {
        Vector3 normal = Vectors.VectorMultiplication(vector1, vector2);


        Vector3 v1 = transform.position - start.position;
        Vector3 v2 = Vectors.Reflect(v1, normal);

        end.position = transform.position + v2;

        lineRenderer.SetPositions(
            new Vector3[5] { 
                start.position, transform.position, 
                transform.position + normal, 
                transform.position,
                end.position });

        text.text = $"start = {v1} \n end = {v2}";
    }
}