using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(timeLaps);    
    }
    void timeLaps(){
        if (Time.timeScale == 1){
            Time.timeScale = 0;
            
        }
        else {
            Time.timeScale = 1;
        }
    }
    
}
