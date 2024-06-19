using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounterVisual : MonoBehaviour
{
    private const string CUT = "Cut";
    
    [SerializeField] private CuttingCounter _cuttingCounter;
    
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _cuttingCounter.OnCut += CuttingCounter_OnCut;
        // _cuttingCounter.OnPlayerGrabbedObject += ContainerCounter_OnPlayerGrabbedObject;
    }

    private void CuttingCounter_OnCut(object sender, EventArgs e)
    {
        _animator.SetTrigger(CUT);
    }
    
}
