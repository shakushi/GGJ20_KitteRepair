using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraController : MonoBehaviour
{
    Animator animator;

    int NoMissCount;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        NoMissCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (STARTController.start)
        {
            NoMissCount = enemiesController.NoMiss;

            if (NoMissCount == 5)
            {
                animator.SetBool("Aura", true);
            }
            else
            {
                animator.SetBool("Aura", false);
            }

            Debug.Log(NoMissCount);
        }
    }
}
