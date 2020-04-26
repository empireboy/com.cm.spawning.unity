using UnityEngine;

namespace CM.Spawning
{
	public sealed class GameObjectSpawnerProxy : MonoBehaviour
	{
		[SerializeField]
		private GameObject _spawnableObject;

		[SerializeField]
		private bool  _spawnOnLoad;

		private GameObjectSpawner _gameObjectSpawner;

		private void Start()
		{
			_gameObjectSpawner = new GameObjectSpawner(_spawnableObject, transform.position, _spawnOnLoad);
		}

		public void Spawn()
		{
			_gameObjectSpawner.Spawn();
		}
	}
}