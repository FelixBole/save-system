using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slax.SaveSystem;

[CreateAssetMenu(menuName = "Save System/Custom Example Save System")]
public class CustomSaveSystem : SaveSystem
{
    private CustomSaveData _customSaveData;

    void OnEnable()
    {
        if (base.SaveData != null)
        {
            _customSaveData = (CustomSaveData)base.SaveData;
        }
        else
        {
            Debug.LogWarning("No Custom Save Data set on the Custom Save System");
        }
    }

    public override void SetNewGameData()
    {
        if (!CheckCustomGameData()) return;

        base.SetNewGameData();
    }

    public override void SaveDataToDisk()
    {
        if (!CheckCustomGameData()) return;

        Debug.Log($"Using {_customSaveData.name} as save data. Current data is: \n PlayerName: {_customSaveData.PlayerName} | Score: {_customSaveData.Score}");

        base.SaveDataToDisk();
    }

    bool CheckCustomGameData()
    {
        if (_customSaveData == null)
        {
            Debug.LogWarning("Null CustomSaveData");
            return false;
        }

        return true;
    }
}