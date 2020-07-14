using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityTools.Common;

namespace UnityFishSimulation
{
    public class StructureModel : MonoBehaviour
    {
        [System.Serializable]
        public class MassPoint: Point
        {
            public float mass;
        }

        [SerializeField] protected List<MassPoint> massNodes = new List<MassPoint>();
        [SerializeField] protected List<Segment<MassPoint>> segments = new List<Segment<MassPoint>>();
        [SerializeField] protected Point ptest = new Point();

        protected void Start()
        {
            var seg = new Segment<MassPoint>();
            this.segments.Add(seg);
            seg.Left.Position = new float3(10,0,0);
        }

        protected void OnDrawGizmos()
        {
            foreach (var s in this.segments) s.OnGizmos();
        }

    }
}
