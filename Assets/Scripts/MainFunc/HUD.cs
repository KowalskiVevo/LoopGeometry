using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public PlayerEntity player;
    void Start()
    {
        Text txt = GetComponent<Text>();
        txt.text = "HP:" + player.health + "\n" +
                   "DEF:" + player.defence + "\n" +
                   "ATK:" + player.atack;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
