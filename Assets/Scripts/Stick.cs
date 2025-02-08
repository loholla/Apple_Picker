using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Stick : MonoBehaviour {
    public static float bottomY = -20f;

    void Update() {
        if (transform.position.y < bottomY) {
            Destroy(this.gameObject);
        }
    }
}
