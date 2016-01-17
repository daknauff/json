using UnityEngine;
using SimpleJSON;
using System.IO;
using System.Collections.Generic;

class Test_CSharp : MonoBehaviour
{
    public List<Item> database = new List<Item>();
    
    void Start()
    {
        var N = JSONNode.Parse((File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json")));
        Debug.Log(N.ToString());
        for (int i = 0; i < N.Count; i++)
        {
            int id = (N["id"].AsInt);
            string title = (N["title"].ToString());

            Debug.Log(id + " en " + title);
            //database.Add(newitem);
            
        }
    }

    [SerializeField]
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