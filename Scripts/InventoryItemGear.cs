using UnityEngine;
using System.Collections;

public class InventoryItemGear : MonoBehaviour {
	
	public int weight;
	public int slotCount;
	public bool isOwned;

	// Use this for initialization
	void Start () 
	{
		if(weight == 0)
		{
			weight = 1;
		}
		InventoryGear.Instance.EchoEvent += HandleEchoEvent;
		if(isOwned)
		{
			InventoryGear.Instance.AddItem(this);
			InventoryGear.Instance.RaiseEcho();
		}

	}

	void HandleEchoEvent (int weight)
	{
		Debug.Log ("Current inventory weight after adding " + this.weight + " is " + weight);
	}

}
