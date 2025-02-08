using UnityEngine;

public enum AddModeMany
{
    String,
    Int,
    Float
}

[System.Serializable]
public class PlayerPrefsEntry
{
    public string playerPrefsKey;
    public string valueToAdd;
    public AddModeMany addMode;
}

public class PlayerPrefsAddMany : MonoBehaviour
{
    public PlayerPrefsEntry[] playerPrefsEntries;

    public void AddValuesToPlayerPrefs()
    {
        foreach (PlayerPrefsEntry entry in playerPrefsEntries)
        {
            if (entry.addMode == AddModeMany.String)
            {
                string currentValue = PlayerPrefs.GetString(entry.playerPrefsKey, string.Empty);
                string updatedValue = currentValue + entry.valueToAdd;
                PlayerPrefs.SetString(entry.playerPrefsKey, updatedValue);
            }
            else if (entry.addMode == AddModeMany.Int)
            {
                int currentValue = PlayerPrefs.GetInt(entry.playerPrefsKey, 0);
                int newValue;
                if (int.TryParse(entry.valueToAdd, out newValue))
                {
                    int updatedValue = currentValue + newValue;
                    PlayerPrefs.SetInt(entry.playerPrefsKey, updatedValue);
                }
            }
            else if (entry.addMode == AddModeMany.Float)
            {
                float currentValue = PlayerPrefs.GetFloat(entry.playerPrefsKey, 0f);
                float newValue;
                if (float.TryParse(entry.valueToAdd, out newValue))
                {
                    float updatedValue = currentValue + newValue;
                    PlayerPrefs.SetFloat(entry.playerPrefsKey, updatedValue);
                }
            }
        }
    }
}