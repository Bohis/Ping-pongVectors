using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vectors {
    /// <summary>
    /// ��������� ������������ (Vector3.Scale)
    /// </summary>
    /// <param name="a">������ ������</param>
    /// <param name="b">������ ������</param>
    /// <returns>������������ ������� �� ������� ���� ����� ����</returns>
    public static float Scalar(Vector3 a, Vector3 b) {
        return a.x * b.x + a.y * b.y;
    }

    /// <summary>
    /// ������� �� ������ � �������
    /// </summary>
    /// <param name="value">�������</param>
    /// <returns>�������</returns>
    public static float FromRadianToDegree(float value)
        => value * 180 / Mathf.PI;

    /// <summary>
    /// �������� ������� a �� ������ b (Vector3.Project)
    /// </summary>
    /// <param name="a">������, ������� ������������</param>
    /// <param name="b">������, �� ������� ���������� ��������</param>
    /// <returns>��������</returns>
    public static float Project(Vector3 a, Vector3 b) {
        return Scalar(a, b) / b.magnitude;
    }

    /// <summary>
    /// ��������� �������, ������������ ������� ������� (Vector3.Reflect)
    /// </summary>
    /// <param name="a">������, ������� ����� ��������</param>
    /// <param name="b">������, ������������ �������� ���������� ��������</param>
    /// <returns>��������� ��������</returns>
    public static Vector3 Reflect(Vector3 a, Vector3 b) {
        Vector3 perpen = Project(a, b) * b.normalized;
        Vector3 parall = a - perpen;

        return parall + (-perpen);
    }


    /// <summary>
    /// ���� ����� ��������� (Vector3.Angle)
    /// </summary>
    /// <param name="a">������ ������</param>
    /// <param name="b">������ ������</param>
    /// <returns>���� �� 0 �� 180 ��������</returns>
    public static float Angle(Vector3 a, Vector3 b) {
        float cos = Scalar(a, b) / (a.magnitude * b.magnitude);
        float acos = Mathf.Acos(cos);
        return FromRadianToDegree(acos);
    }

    /// <summary>
    /// ��������� ������������ (Vector3.Cross)
    /// </summary>
    /// <param name="a">������ ������</param>
    /// <param name="b">������ ������</param>
    /// <returns>��������� ���������� ������������</returns>
    public static Vector3 VectorMultiplication(Vector3 a, Vector3 b) {
        return new Vector3(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x);
    }
}