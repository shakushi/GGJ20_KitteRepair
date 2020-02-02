using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerController : MonoBehaviour
{
    //トータルの制限時間
    private float totalTime;

    //秒
    [SerializeField]
    public float seconds;
    //前のupdate字の秒数 
    private float oldSeconds;
    //タイマー用テキスト
    private Text timerText;

    public static bool isClear;
    public GameObject obj;
    private PanelAction act;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
        isClear = false;
        act = obj.GetComponent<PanelAction>();

    }

    // Update is called once per frame
    void Update()
    {
        if (STARTController.start)
        {
            if (!isClear)
            {
                //　制限時間が0秒以下なら何もしない
                if (totalTime < 0f)
                {
                    return;
                }

                //　トータルの制限時間を計算
                totalTime -= Time.deltaTime;
                //Debug.Log("totalTime = " + totalTime);

                if (totalTime <= 0f)
                {
                    act.setFinish();
                    isClear = true;
                    SceneManager.LoadScene("result", LoadSceneMode.Additive);
                }
            }
            else
            {
                totalTime = 0.0f;
            }

            //　タイマー表示用UIテキストに時間を表示する
            if (totalTime != oldSeconds)
            {
                // timerText.text = minute.ToString("0") + ":" + ((int)seconds).ToString("00");
                timerText.text = (totalTime).ToString("00.00");
            }
            oldSeconds = totalTime;
        }
    }
}