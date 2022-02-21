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

        TextQuote.text = phases.PhasesList[index];

        TextAuthor.text  = phases.author;


 
    }


}
