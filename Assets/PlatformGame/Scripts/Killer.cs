﻿using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            Destroy(other.gameObject);
        }
    }

}
