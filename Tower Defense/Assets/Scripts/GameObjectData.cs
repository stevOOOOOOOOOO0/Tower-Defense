using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameObjectData : ScriptableObject
{

    public GameObject Value;

    public void GetObject(GameObject GameObj)
    {
        Value = GameObj;
    }

    public void SetPosition(Transform Location)
    {
        Value.transform.position = Location.position;
        Value.transform.rotation = Location.rotation;
    }
}