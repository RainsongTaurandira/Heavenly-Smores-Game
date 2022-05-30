﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    [SerializeField]
    private Text chocolateCounter, marshmallowCounter, crackerCounter, stickCounter;

    private int chocolateAmount, crackerAmount, marshmallowAmount, stickAmount;

    void Start()
    {
        chocolateAmount = 0;
        crackerAmount = 0;
       marshmallowAmount = 0;
        stickAmount = 0;
    }

    void Update()
    {
        chocolateCounter.text = "Chocolate: " + chocolateAmount;
        marshmallowCounter.text = "Marshmallow: " + marshmallowAmount;
        crackerCounter.text = "Crackers: " + crackerAmount;
        stickCounter.text = "Sticks: " + stickAmount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<chocolate>())
        {
            chocolateAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<marshmallow>())
        {
            marshmallowAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<cracker>())
        {
            crackerAmount += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.GetComponent<stick>())
        {
            stickAmount += 1;
            Destroy(collision.gameObject);
        }
    }
} // class




