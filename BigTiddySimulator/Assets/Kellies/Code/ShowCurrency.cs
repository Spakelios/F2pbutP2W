using UnityEngine;
 
[CreateAssetMenu(menuName = "Scriptable Objects/Variables/Integer Variable")]
public class ShowCurrency : ScriptableObject
{
    public static int totalNotes = 0;

    public static int stings = 0, screws = 0, pucks = 0, brokenKey = 0;
    
    public static int level = 1;

    public static int wall, ponytail, glasses;
}
