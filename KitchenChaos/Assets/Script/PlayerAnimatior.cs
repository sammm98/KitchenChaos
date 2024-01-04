using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatior : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";
    private Animator animator;
    [SerializeField] private Player player;
    private void Awake()
    {
        animator = GetComponent<Animator>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(IS_WALKING, player.IsWalking());
    }
}
