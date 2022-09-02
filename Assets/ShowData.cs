using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ShowData : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public Data data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Eng:" + data.engagment + "\nExt:" + data.excitment + "\nFcs:" + data.focus + "\nInt:" + data.interest + "\nRel:" + data.relaxation + "\nStr:" + data.stress;
    }
}
