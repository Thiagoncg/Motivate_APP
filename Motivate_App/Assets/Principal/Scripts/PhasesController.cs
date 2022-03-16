using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhasesController : MonoBehaviour
{
    public Phases phases;
    public TextMeshProUGUI TextQuote;
    public TextMeshProUGUI TextAuthor;
    void Start()
    {
        phases = new Phases();

        LoadPhasesBr();
    }
    public void LoadPhasesBr()
    {
        phases.LoadBr();



        int index = Random.Range(0, phases.PhasesList.Count);

        //TextQuote.text = phases.PhasesList[50];

       // TextAuthor.text = phases.author;
        
        //Debug.Log("Scene 0 id:" + container.scenes[0].annoID);
        //Debug.Log("Frase escolhida foi: " + phases.PhasesList[50]);
        //Debug.Log(phases.PhasesList.Count);
        Debug.Log(index);

    }
}
