using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace UnityFishSimulation
{
    public class StructureModel : MonoBehaviour
    {
        [System.Serializable]
        public struct MassNode
        {
            public float3 pos;
            public float mass;
        }
        [SerializeField] protected List<MassNode> massNodes = new List<MassNode>();

    }
}
