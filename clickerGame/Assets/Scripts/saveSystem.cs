using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class saveSystem
{
    //3 different saves - settings, meta, full
    //only one settings
    //one meta + one full for each save

    public static void savePlayer(mapManager map, countInt count, itemManager item)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/test.mmn";
        FileStream steam = new FileStream(path, FileMode.Create);

        savePlayerData data = new savePlayerData(map, count, item);

        formatter.Serialize(steam, data);
        steam.Close();
    }
    public static savePlayerData loadPlayer()
    {
        string path = Application.persistentDataPath + "/test.mmn";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            savePlayerData data = formatter.Deserialize(stream) as savePlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found at: " + path);
            return null;
        }
    }

    //public static void savePlayerMetaData(savePlayerMetaData metaData)
    //public static void saveGameSettings(saveSettingsData settingsData)
}
