using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slax.SaveSystem;

/// <summary>EXAMPLE CLASS OF HOW TO EXPAND THE BASE SAVE CLASS</summary>
[CreateAssetMenu(menuName = "Save System/Custom Example Save Data")]
public class CustomSaveData : SaveData
{
    public string PlayerName = "Bob";
    public int Score = 100;
}
