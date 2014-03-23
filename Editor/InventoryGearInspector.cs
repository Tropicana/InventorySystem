using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(InventoryGear))]
public class InventoryGearInspector : Editor 
{

	public override void OnInspectorGUI()
	{
		InventoryGear myTarget = (InventoryGear)target;
		
		myTarget._currentWeight = EditorGUILayout.IntField("Current Weight", myTarget._currentWeight);
		EditorGUILayout.LabelField("Current Weight", myTarget._currentWeight.ToString());
	} 

}
