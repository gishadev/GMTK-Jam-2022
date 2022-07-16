﻿using UnityEngine;

namespace Gisha.GMTK2022.Core
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Scriptable Objects/GameData", order = 0)]
    public class GameData : ScriptableObject
    {
        [SerializeField] private GameObject masterDicePrefab;
        [SerializeField] private GameObject[] rulesDicePrefabs;


        public GameObject[] RulesDicePrefabs => rulesDicePrefabs;

        public GameObject MasterDicePrefab => masterDicePrefab;
    }
}