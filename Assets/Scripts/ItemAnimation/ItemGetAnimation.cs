using UnityEngine;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;

namespace Item
{
    public class ItemGetAnimation
    {
        /// <summary>
        /// アイテムトランジションアニメーション
        /// </summary>
        /// <returns></returns>
        public static async UniTask ItemGetAnimationAsync(Transform item, Transform target, CancellationToken cancellationToken)
        {
            await item.DOMove(target.transform.position, 1f).WithCancellation(cancellationToken);
        }
    }
}
