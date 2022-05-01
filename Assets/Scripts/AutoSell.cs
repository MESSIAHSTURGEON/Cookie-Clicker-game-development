using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;
    public GameObject statusBox;
    public GameObject textbox;
    public bool SellCookie;

    public static bool SetActive { get; private set; }

    void Update()
    {
        CashIncrease = GlobalCashier.SellPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
        else if (GlobalCookies.CookieCount == 0)
        {
            AutoSell.SetActive = false;
            statusBox.GetComponent<Text>().text = "Not enough Cookies to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            
        }
        IEnumerator SellTheCookie()
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
    }
}
