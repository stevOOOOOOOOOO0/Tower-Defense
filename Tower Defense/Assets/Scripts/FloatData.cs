using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{

	public float Value;

	public void DoubleValue()
	{
		Value = Value * 2;
	}

	public void HalfValue()
	{
		Value = Value / 2;
	}
}