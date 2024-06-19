using Item;
using UnityEngine;
using Cysharp.Threading.Tasks.Triggers;
using Cysharp.Threading.Tasks.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace GameScene
{
    using Player;
    public class GameScenePresenter : MonoBehaviour
    {
        [SerializeField]
        ItemGetCollider[] itemGetColliders = null;
        [SerializeField]
        Player player;

        private void Start()
        {
            foreach (var collider in itemGetColliders)
            {
                collider.GetAsyncTriggerStayTrigger()
                    .Subscribe(col =>
                    {
                        if (col.gameObject.CompareTag("Player"))
                        {
                            //playerに対してアイテム送る
                            Debug.Log("あたったー");

                        }
                    }).AddTo(destroyCancellationToken);
            }

        }
    }
}