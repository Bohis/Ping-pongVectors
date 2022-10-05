using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int point = 0;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Ball") {
            ++point;
            text.text = point.ToString();
        }
    }
}
