using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject FakeText;
    public GameObject FakeButton;
    public GameObject RealButton;
    public GameObject RealText;
    public int currentCash;
    public static int bakerValue = 5;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberOfBakers + " @ " + bakePerSec + "Per Second";
        FakeText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;
        RealText.GetComponent<Text>().text = "Buy Baker - $" + bakerValue;

        if(currentCash >= bakerValue)
        {
            FakeButton.SetActive(false);
            FakeText.SetActive(false);
            RealButton.SetActive(true);
            RealText.SetActive(true);
        }
        if (turnOffButton == true)
        {
            RealButton.SetActive(false);
            RealText.SetActive(false);
            FakeButton.SetActive(true);
            FakeText.SetActive(true);
            turnOffButton = false;
        }
    }
}
