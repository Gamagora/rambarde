﻿using System;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class Skill : ScriptableObject {
    [SerializeField] private bool shouldCastOnAllies;

    public bool ShouldCastOnAllies => shouldCastOnAllies;

    public abstract void Execute(Character target);
}