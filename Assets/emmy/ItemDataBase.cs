/*
using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.IO;
using System.Linq;

public class ItemDataBase : MonoBehaviour {

	private List<Item> database = new List<Item> ();
//	private JsonData itemData;

	void Start()
	{
		//improved version from comments
		//database = JsonMapper.ToObject<List<Item>>(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));


		//testcode to check if the class works
		//Item item = new Item(0, "ball");
		//database.Add (item);
		//Debug.Log (database[0].Title);



		//original code from tutorial
	//	itemData = JsonMapper.ToObject (File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
		ConstructItemDatabase();

		Debug.Log (database [3].Title);
	}



	//fetches the item with specific Item ID
	//public Item FetchItemByID(int id)
	//{
	//	return database.First (item => item.ID == id);
	//}



	//reads from Items database text file
	void ConstructItemDatabase()
	{
		for (int i = 0; i < itemData.Count; i++) {

			database.Add(new Item((int)itemData[i]["id"], itemData[i]["title"].ToString()));
	
			}
		}



	//define the Item class 
	public class Item

	{
		public int ID { get; set; }
		public string Title { get; set;}

		public Item(int id, string title) 
		{
			this.ID = id;
			this.Title = title;
		}



	}
}*/