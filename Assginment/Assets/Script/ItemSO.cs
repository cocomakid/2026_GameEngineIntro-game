using UnityEngine;

[CreateAssetMenu(fileName = "ItemSo", menuName = "Scriptable Objects/ItemSo")]
public class ItemSO : ScriptableObject
{
    [Header("Score Value")]
    public int point = 10;
}

