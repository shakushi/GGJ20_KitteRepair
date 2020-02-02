using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resultaction1 : MonoBehaviour
{
    // public GameObject obj;
    public Text text;
    public static bool a;

    // Start is called before the first frame update
    void Start()
    {
        var values = PlayerPrefs.GetString("score_ranking");
        if (values == "")
        {
            values = "0";
        }
        values = values + "," + ActionResult.point.ToString();
        Debug.Log("1:" + values);
        PlayerPrefs.SetString("score_ranking", values); // 結果を保存

        this.text = GetComponentInChildren<Text>();
        this.text.text = "Score: " + ActionResult.point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // nothing
    }
}