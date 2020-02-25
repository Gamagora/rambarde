﻿using UnityEngine;

namespace Bard
{
    [CreateAssetMenu(fileName = "Instrument", menuName = "Instrument")]
    public class Instrument : ScriptableObject {
        public Melodies.Melody[] melodies;
    }
}
