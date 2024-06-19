using UnityEngine;
using System.Collections.Generic;

namespace Sound
{
    /// <summary>
    /// サウンドマネージャー
    /// </summary>
    public sealed class SoundManager : MonoBehaviour, ISoundManager
    {
        /// <summary>
        /// BGM用のオーディオソース
        /// </summary>
        [SerializeField]
        AudioSource audioSourceBGM;

        /// <summary>
        /// SE用のオーディオソース
        /// </summary>
        [SerializeField]
        AudioSource audioSourceSE;

        /// <inheritdoc/>
        public bool IsPlayBGM()
        {
            return audioSourceBGM.isPlaying;
        }

        /// <inheritdoc/>
        public void PlayBGM(AudioClip bgmClip, bool isloop = true)
        {
            // クリップがnullなら抜ける
            if (bgmClip == null)
            {
                return;
            }

            audioSourceBGM.clip = bgmClip;
            audioSourceBGM.loop = isloop;
        }

        /// <inheritdoc/>
        public void PlaySE(AudioClip seClip)
        {
            // クリップnullなら抜ける
            if (seClip == null)
            {
                return;
            }
            audioSourceSE.clip = seClip;
        }

        /// <inheritdoc/>
        public void SetVolumeBGM(float volume)
        {
            audioSourceBGM.volume = volume;
        }

        public void SetVolumeSE(float volume)
        {
            audioSourceSE.volume = volume;
        }
    }
}