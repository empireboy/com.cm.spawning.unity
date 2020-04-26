using UnityEngine;

namespace CM.Spawning
{
	public class GameObjectSpawner : SingleObjectSpawner<GameObject>
	{
		public new Vector3 Position { get; set; }

		public GameObjectSpawner(GameObject spawnableObject, Vector3 position, bool spawnOnLoad) : base(spawnableObject, new System.Numerics.Vector3(position.x, position.y, position.z), spawnOnLoad)
		{
			Position = position;

			OnLoad();
		}

		public override GameObject OnSpawn(GameObject spawnableObject)
		{
			return Object.Instantiate(spawnableObject, Position, spawnableObject.transform.rotation);
		}
	}
}