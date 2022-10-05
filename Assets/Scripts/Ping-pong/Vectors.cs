using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vectors {
    /// <summary>
    /// Скалярное произведение (Vector3.Scale)
    /// </summary>
    /// <param name="a">Первый вектор</param>
    /// <param name="b">Второй вектор</param>
    /// <returns>Произведение модулей на косинус угла между ними</returns>
    public static float Scalar(Vector3 a, Vector3 b) {
        return a.x * b.x + a.y * b.y;
    }

    /// <summary>
    /// Перевод из радиан в градусы
    /// </summary>
    /// <param name="value">Радианы</param>
    /// <returns>Градусы</returns>
    public static float FromRadianToDegree(float value)
        => value * 180 / Mathf.PI;

    /// <summary>
    /// Проекция вектора a на вектор b (Vector3.Project)
    /// </summary>
    /// <param name="a">Вектор, который проецируется</param>
    /// <param name="b">Вектор, на который происходит проекция</param>
    /// <returns>Проекция</returns>
    public static float Project(Vector3 a, Vector3 b) {
        return Scalar(a, b) / b.magnitude;
    }

    /// <summary>
    /// Отражение вектора, относительно другого вектора (Vector3.Reflect)
    /// </summary>
    /// <param name="a">Вектор, который нужно отразить</param>
    /// <param name="b">Вектор, относительно которого происходит проекция</param>
    /// <returns>Результат проекции</returns>
    public static Vector3 Reflect(Vector3 a, Vector3 b) {
        Vector3 perpen = Project(a, b) * b.normalized;
        Vector3 parall = a - perpen;

        return parall + (-perpen);
    }


    /// <summary>
    /// Угол между векторами (Vector3.Angle)
    /// </summary>
    /// <param name="a">Первый вектор</param>
    /// <param name="b">Второй вектор</param>
    /// <returns>Угол от 0 до 180 градусов</returns>
    public static float Angle(Vector3 a, Vector3 b) {
        float cos = Scalar(a, b) / (a.magnitude * b.magnitude);
        float acos = Mathf.Acos(cos);
        return FromRadianToDegree(acos);
    }

    /// <summary>
    /// Векторное произведение (Vector3.Cross)
    /// </summary>
    /// <param name="a">Первый вектор</param>
    /// <param name="b">Второй вектор</param>
    /// <returns>Результат векторного произведения</returns>
    public static Vector3 VectorMultiplication(Vector3 a, Vector3 b) {
        return new Vector3(
            a.y * b.z - a.z * b.y,
            a.z * b.x - a.x * b.z,
            a.x * b.y - a.y * b.x);
    }
}