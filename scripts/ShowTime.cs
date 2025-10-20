using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using System;

public class ShowTime : MonoBehaviour
{
    private TextMeshProUGUI timeText;
    private float timeStart;

    // Start is called before the first frame update
    void Start()
    {
        timeText = this.GetComponent<TextMeshProUGUI>();
        timeText.text = "start";
        timeStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = (Time.time-timeStart).ToString("0.000") + " sec";
    }
}
