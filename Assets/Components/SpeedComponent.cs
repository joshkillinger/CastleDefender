using OOECS.Component;
using UnityEngine;

namespace CastleDefender.Components
{
    public class SpeedComponent : VersionedComponent
    {
        public Vector3 BaseSpeed;
        public Vector3 CurrentSpeed = Vector3.zero;
        public Vector3 Acceleration;
        
        public SpeedComponent(Vector3 baseSpeed, Vector3 acceleration)
        {
            BaseSpeed = baseSpeed;
            Acceleration = acceleration;
        }
    }
}