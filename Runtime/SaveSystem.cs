using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Slax.SaveSystem
{
    /// <summary>Parent class for custom save systems containing basic functionnality</summary>
    public class SaveSystem : ScriptableObject
    {
        public string SaveFileName;
        public string BackupSaveFileName;

        public SaveData SaveData;

        [ContextMenu("Load Data")]
        public virtual bool LoadSaveDataFromDisk()
        {
            if (FileManager.LoadFromFile(SaveFileName, out var json))
            {
                SaveData.LoadFromJson(json);
                return true;
            }

            return false;
        }

        [ContextMenu("Save Data")]
        public virtual void SaveDataToDisk()
        {
            Debug.Log("Saving data to disk.");

            if (FileManager.MoveFile(SaveFileName, BackupSaveFileName))
            {
                if (FileManager.WriteToFile(SaveFileName, SaveData.ToJson()))
                {
                    Debug.Log("Game Saved !");
                }
            }
        }

        public virtual void WriteEmptySaveFile()
        {
            Debug.Log("Writing empty save file.");

            FileManager.WriteToFile(SaveFileName, "");
        }

        [ContextMenu("Set New Game Data")]
        public virtual void SetNewGameData()
        {
            Debug.Log("Setting up new game data.");

            WriteEmptySaveFile();
            SaveDataToDisk();
        }
    }
}
