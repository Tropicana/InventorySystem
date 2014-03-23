using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryGear : MonoBehaviour 
{
	public int maxWeight;
	public int _currentWeight;
	public int maxSlots;
	public int _currentSlotCount;
	//private int _currentItems;
	public List<InventoryItemGear> _slots;

	private static InventoryGear _instance;

	public static InventoryGear Instance
	{
		get
		{
			return _instance;
		}
	}

	// Use this for initialization
	void Awake () 
	{
		if(_instance == null)
			_instance = this;
	}

	void Start()
	{
		if(maxWeight == 0)
			maxWeight = System.Int32.MaxValue;
	}

	public void AddItem(InventoryItemGear item)
	{
		int newWeight = _currentWeight + item.weight;
		int newSlotCount = _currentSlotCount + item.slotCount;
		if(newWeight <= maxWeight && newSlotCount <= maxSlots)
		{
		  _slots.Add(item);
			_currentWeight = newWeight;
			_currentSlotCount = newSlotCount;

		}
	}

//******************Small Test***********************************************//
	public void RaiseEcho()
	{
		if(EchoEvent != null)
			EchoEvent(_currentWeight);
	}

	public delegate void VoidFunc(int weight);
	public event VoidFunc EchoEvent;
//******************Small Test***********************************************//

}
