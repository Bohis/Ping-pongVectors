using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Proection : MonoBehaviour {
    public Transform start;
    public Transform end;
    public Transform Plane;

    public LineRenderer lineRenderer1;
    public LineRenderer lineRenderer2;

    private void Awake() {
        lineRenderer1.positionCount = 3;
        lineRenderer2.positionCount = 2;
    }

    private void Update() {
        Vector3 projection = (Plane.position - transform.position).normalized
            * Vectors.Project((transform.position - start.position), (Plane.position - transform.position));

        end.position = transform.position + -projection;

        lineRenderer1.SetPositions(new Vector3[] { start.position, transform.position, end.position });
        lineRenderer2.SetPositions(new Vector3[] { transform.position, Plane.position });
    }
}