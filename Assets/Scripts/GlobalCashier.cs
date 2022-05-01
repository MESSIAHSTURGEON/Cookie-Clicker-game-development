using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCashier : MonoBehaviour
{
    public GameObject FakeText;
    public GameObject FakeButton;
    public GameObject RealButton;
    public GameObject RealText;
    public int currentCookies;
    public int currentCash; 
    public static int CashierValue = 50;
    public static bool turnOffButton = false;
    public GameObject CashierStats;
    public static int numberOfCashiers;
    public static int SellPerSec;
    void Update()
    {
        currentCookies = GlobalCookies.CookieCount;
        currentCash = GlobalCash.CashCount;
        CashierStats.GetComponent<Text>().text = "Cashier: " + numberOfCashiers + " @ " + SellPerSec + "Per Second";
        FakeText.GetComponent<Text>().text = "Buy Cashier - $" + CashierValue;
        RealText.GetComponent<Text>().text = "Buy Cashier - $" + CashierValue;

        if (currentCash >= CashierValue)
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
