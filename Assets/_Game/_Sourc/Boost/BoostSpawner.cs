using System.Collections;
using UnityEngine;

namespace Game.Global
{
    public class BoostSpawner : MonoBehaviour
    {
        [SerializeField] private Boost _prefab;
        [SerializeField] private float _timeBeforSpawn;
        [SerializeField] private Vector2 _firstFrontier;
        [SerializeField] private Vector2 _secondFrontier;
        [SerializeField] private BoostFactory _factory;

        private void Awake() => StartCoroutine(BoostsSpawn());

        private IEnumerator BoostsSpawn()
        {
            yield return new WaitForSeconds(_timeBeforSpawn);
            Vector2 SpawnPosition = new Vector2(Random.Range(_firstFrontier.x, _secondFrontier.x), Random.Range(_firstFrontier.y, _secondFrontier.y));
            _factory.Get(_prefab , SpawnPosition);
            StartCoroutine(BoostsSpawn());
        }

    }
}

