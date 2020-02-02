using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoController : MonoBehaviour
{
    public GameObject pointObject;
    
    private int maxPoint;
    private Text ammoText;

    // Start is called before the first frame update
    void Start()
    {
            var score = 0;
            var values = PlayerPrefs.GetString("score_ranking");
            if (values != "")
            {
                score = values.Split(',').Select(v => Int32.Parse(v)).Max();
            }
            this.ammoText = GetComponentInChildren<Text>();
            this.ammoText.text = score.ToString();
     }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(ActionResult.point);
        // if (this.maxPoint < ActionResult.point)
        // {
        //    this.maxPoint = ActionResult.point;
        //    this.ammoText.text = this.maxPoint.ToString();
        //}
    }
}
