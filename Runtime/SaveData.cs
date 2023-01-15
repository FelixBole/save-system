using System;
using System.Collections.Generic;
using UnityEngine;

namespace Slax.SaveSystem
{
    ///<summary>Parent class for the actual Save class that will contain everything to be serialized and saved</summary>
    [Serializable]
    public class SaveData: ScriptableObject
    {
        public string ToJson()
        {
            return JsonUtility.ToJson(this);
        }

        public void LoadFromJson(string json)
        {
            JsonUtility.FromJsonOverwrite(json, this);
        }
    }
}
