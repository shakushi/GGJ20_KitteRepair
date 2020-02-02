using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STARTController : MonoBehaviour
{
    Text StartText;
    int countDown;
    int checkCountDown;

    public static bool start;
    // Start is called before the first frame update
    void Start()
    {
        StartText = GetComponent<Text>();
        countDown = 3;
        checkCountDown = 3;

        start = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        StartText.gameObject.SetActive(true);


        if(checkCountDown == 3)
        {
            countDown = 3;
        }

        if (countDown == 3)
        {
            StartText.text = "3";
            yield return new WaitForSeconds(1.0f);
            checkCountDown = 2;
        }


        if (checkCountDown == 2)
        {
            countDown = 2;
        }

        if (countDown == 2)
        {
            StartText.text = "2";
            yield return new WaitForSeconds(1.0f);
            checkCountDown = 1;
        }


        if (checkCountDown == 1)
        {
            countDown = 1;
        }

        if (countDown == 1)
        {
            StartText.text = "1";
            yield return new WaitForSeconds(1.0f);
            checkCountDown = 0;
        }


        if (checkCountDown == 0)
        {
            countDown = 0;
        }

        if (countDown == 0)
        {
            StartText.text = "START!";
            yield return new WaitForSeconds(1.0f);
        }
        StartText.text = "";
        StartText.gameObject.SetActive(false);
        start = true;
    }
}
