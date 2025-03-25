using System;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender
{
    public class GameSetup : MonoBehaviour
    {
        private void Awake()
        {
            EntityManager.Reset();
        }
    }
}