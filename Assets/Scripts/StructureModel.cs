using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityFishSimulation
{
    public class StructureModel : MonoBehaviour
    {
        public struct MassNode
        {

            public float mass;
        }
        [SerializeField] protected List<MassNode> massNodes = new List<MassNode>();

    }
}
