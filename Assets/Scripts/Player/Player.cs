using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        readonly string holdLayerName = "Hold Layer";

        int holdLayerIndex;

        [SerializeField]
        Animator animator;
        [SerializeField]
        Transform holdItemParentRT;

        /// <summary>
        /// アイテム持つ場所のTransformを取得する
        /// </summary>
        /// <returns></returns>
        public Transform GetHoldItemPatent()
        {
            return holdItemParentRT;
        }

        private void Start()
        {
            holdLayerIndex = animator.GetLayerIndex(holdLayerName);
        }

        /// <summary>
        /// アイテムホールド時のアニメーション
        /// </summary>
        public void ItemHoldAnimation(float weight)
        {
            animator.SetLayerWeight(holdLayerIndex, weight);
        }
    }
}
