﻿using Structs;
using UnityEngine;

namespace Skills {
    [CreateAssetMenu(fileName = "Attaque75", menuName = "Skills/Attaque75")]
    public class Atq75Skill : Skill {
        public override void Execute(Stats stats, Character target) {
            float rand = Random.Range(0, 100);
            if (rand >= 75) {
                Debug.Log("Miss!");
                return;
            }
        
            target.TakeDamage(stats.atq);
            // Debug.Log(stats.atq + " inflicted to " + target.name + ".\tNew Endurance: " + target.stats.end);
        }
    }
}