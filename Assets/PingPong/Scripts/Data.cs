using dirox.emotiv.controller;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public DataSubscriber data;
    void Start()
    {
        
    }
     

    public double engagment, excitment, lex, stress, relaxation, interest, focus;
    // Update is called once per frame
    public void calculatePM(double[] data)
    {
        //Performance metrics Data: 1592752477.3884, 0.560504, 0, 0, 0, 0.30294, 0.651354, 0.086895, 
        //Performance metrics Header: TIMESTAMP, eng, exc, lex, str, rel, int, foc, 
        engagment = data[1];
        excitment = data[2];
        lex = data[3];
        stress = data[4];
        relaxation = data[5];
        interest = data[6];
        focus = data[7];

    }
    public void calculateEEG(string data, string header)
    {

    }
    public void calculateM(string data, string header)
    {

    }

}
