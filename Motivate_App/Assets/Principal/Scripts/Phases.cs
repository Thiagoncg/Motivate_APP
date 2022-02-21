using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[Serializable]
public class Phases
{
    public int id;
    public string quote;
    public string author;

    public List<string> PhasesList = new List<string>();
    //private string path_Br = "Assets/Resouces/Phases_br.json";
    private string path_Br = "Assets/Resouces/PhasesTeste.json";



    public void LoadBr()
    {
        var content = File.ReadAllText(path_Br);
        var pathBr = JsonUtility.FromJson<Phases>(content);

        id = pathBr.id;
        quote = pathBr.quote;
        author = pathBr.author;
        PhasesList = pathBr.PhasesList;
       
    }

}
