using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Database", menuName = "Scriptable Objects/New Item Database")]
public class itemDatabase : ScriptableObject
{
    public List<shopItemSO> listOfItems;
}
