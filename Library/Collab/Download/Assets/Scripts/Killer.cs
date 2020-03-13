﻿/*
 * Kills enemies and player
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private int touchCount;
    // Start is called before the first frame update
    void Start()
    {
        touchCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll) {
        if(++touchCount == 2) {
            if (coll.gameObject.tag.Equals("Player") || coll.gameObject.tag.Equals("Enemy")) {
                Destroy(coll.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
