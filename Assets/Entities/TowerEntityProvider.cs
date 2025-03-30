using System;
using OOECS.Entity;
using UnityEngine;

namespace CastleDefender.Entities
{
    public class TowerEntityProvider : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<EntityProvider>().Data = EntityManager.GetEntityById(1);
        }
    }
}