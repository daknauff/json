using UnityEngine;
using SimpleJSON;
using System.IO;
using System.Collections.Generic;

class Test_CSharp : MonoBehaviour
{
    private List<Item> database = new List<Item>();
    
    void Start()
    {
        //var N = JSONNode.LoadFromFile(Application.dataPath + "/StreamingAssets/Items.json");
        var N = JSONNode.Parse((File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json")));
        Debug.Log(N.ToString());
        for (int i = 0; i < N.Count; i++)
        {
            int id = (N[i]["id"].AsInt);
            string title = (N[i]["title"].Value);
            Item newitem = new Item(id, title);
            Debug.Log(newitem.ID + " en " + newitem.Title);
            database.Add(newitem);
            Debug.Log(database[i].ID + " en " + database[i].Title);

        }
    }

    
    public class Item

    {
        public int ID { get; set; }
        public string Title { get; set; }

        public Item(int id, string title)
        {
            this.ID = id;
            this.Title = title;
        }



    }
}