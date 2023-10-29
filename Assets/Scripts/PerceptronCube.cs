using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Perceptron))]
public class PerceptronCube : MonoBehaviour
{
    public Material ZeroMaterial;
    public Material OneMaterial;

    private Perceptron perceptron;

    private void Start()
    {
        perceptron = GetComponent<Perceptron>();
        GetComponent<MeshRenderer>().material = perceptron.CalcOutput(0, 0) == 0 ? ZeroMaterial : OneMaterial;
    }

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<MeshRenderer>().material = perceptron.CalcOutput(0, 1) == 0 ? ZeroMaterial : OneMaterial;
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material = perceptron.CalcOutput(1, 1) == 0 ? ZeroMaterial : OneMaterial;
    }
}