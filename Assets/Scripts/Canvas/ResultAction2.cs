using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class ResultAction2 : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        var values = PlayerPrefs.GetString("score_ranking");
        if (values != "")
        {
            Debug.Log("v:" + values);
            List<Int32> tvalues = new List<Int32>() { 1, 2, 3 };
            var intValues = values.Split(',')
                            .Select(v => Int32.Parse(v))
                            .Where(v => v != 0)
                            .OrderBy(v => -v)
                            .Take(3)
                            .ToList();
            // Debug.Log(intValues);
            var ranking_strs = tvalues
                .Zip(intValues, (v1, v2) => v1.ToString() + ": " + v2.ToString());
            var ranking_str = "Ranking:\n";
            // Debug.Log(String.Join(",", ranking_strs));
            ranking_str += String.Join("\n", ranking_strs);
            this.text = GetComponentInChildren<Text>();
            this.text.text = ranking_str;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
