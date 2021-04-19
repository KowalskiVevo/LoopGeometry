using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossBar : MonoBehaviour
{
    [SerializeField]
    private Image bossbar;
    [SerializeField]
    private float fill = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bossbar.fillAmount = fill;
        if (Input.GetMouseButtonDown(0))
        {
            if (fill > 0)
                fill -= 0.25f;
        }
    }
}
