using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] Upgrades;
    public Image background;
    public TextMeshProUGUI numberDisplay;
    public double value;
    double number;

    float timer;

    void Start()
    {
        timer = 1;
        value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        switch(number)
        {
            case 10:
                Upgrades[0].SetActive(true);
                break;
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }

        else
        {
            
            number += value;
            numberDisplay.text = "" + number;
            timer = 1;
        }
    }
}
