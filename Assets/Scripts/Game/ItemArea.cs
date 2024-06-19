using Cysharp.Threading.Tasks.Triggers;
using Cysharp.Threading.Tasks.Linq;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Data;
using Player;
using R3;
using R3.Triggers;

namespace Item
{
    public class ItemArea : MonoBehaviour
    {
        public ItemKindData itemData = new ItemKindData(ItemKind.Apple, "Apple");

        // コライダーが当たった時にここで生成させる
        // 生成側のコードはまた別でつくる
        // ここでは生成する際の情報を分けて持っておくことが重要
        private void Start()
        {
            this.OnTriggerStayAsObservable()
                .Select(collider => new {collider, itemData.assetPath})
                .SubscribeAwait(async static (param, ct) =>
                {
                    if (param.collider.gameObject.CompareTag("Player"))
                    {
                        var playerComponent = param.collider.gameObject.GetComponent<Player.Player>();
                        // アイテムのロード
                        var itemAsset = await Addressables.LoadAssetAsync<GameObject>(param.assetPath).WithCancellation(ct);
                        
                    }
                },AwaitOperation.Drop);

        }
    }
}
