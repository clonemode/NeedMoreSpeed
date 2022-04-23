using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{

    public  int MinuteCount;
    public  int SecondCount;
    public  float MilliCount;
    public  string MilliDisplay;

    public int LastMinuteCount;
    public int LastSecondCount;
    public float LastMilliCount;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;

    public GameObject LastMinuteBox;
    public GameObject LastSecondBox;
    public GameObject LastMilliBox;


    void Update()
    {
        MilliCount += Time.deltaTime * 10;
        MilliDisplay = MilliCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

        if (MilliCount >= 9)
        {
            MilliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
        }

        if (SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        
        
       if (other.gameObject.CompareTag("CheckPoints"))
            {
                LastMilliCount = MilliCount;
                MilliCount = 0;
                LastSecondCount = SecondCount;
                SecondCount = 0;
                LastMinuteCount = MinuteCount;
                MinuteCount = 0;



                if (LastSecondCount <= 9)
                {
                    LastSecondBox.GetComponent<Text>().text = "0" + LastSecondCount + ".";
                }
                else
                {
                    LastSecondBox.GetComponent<Text>().text = "" + LastSecondCount + ".";
                }

                if (LastMinuteCount <= 9)
                {
                    LastMinuteBox.GetComponent<Text>().text = "0" + LastMinuteCount + ":";
                }
                else
                {
                    LastMinuteBox.GetComponent<Text>().text = "" + LastMinuteCount + ":";
                }
                if (LastMilliCount <= 9)
                {
                    LastMilliBox.GetComponent<Text>().text = "0" + LastMilliCount + ":";
                }
                else
                {
                    LastMilliBox.GetComponent<Text>().text = "" + LastMilliCount + ":";
                }

       }

    }
}