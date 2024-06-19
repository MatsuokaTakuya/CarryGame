using Unity.VisualScripting;
using UnityEngine;

namespace Sound
{
    public interface ISoundManager
    {
        /// <summary>
        /// BGMの再生状態を取得
        /// </summary>
        /// <returns></returns>
        bool IsPlayBGM();

        /// <summary>
        /// BGMを再生させる（外部からクリップを指定する
        /// </summary>
        /// <param name="bgmClip">BGMのクリップ</param>
        /// <param name="isloop">ループ指定</param>
        void PlayBGM(AudioClip bgmClip, bool isloop = true);

        /// <summary>
        /// SEを再生させる（外部からクリップを指定する
        /// </summary>
        /// <param name="seClip">SEのクリップ</param>
        void PlaySE(AudioClip seClip);

        /// <summary>
        /// BGM AudioSourceのボリュームを設定する
        /// ＊0f～1fの数値指定
        /// </summary>
        /// <param name="volume">ボリューム値</param>
        void SetVolumeBGM(float volume);

        /// <summary>
        /// SE AudioSourceのボリュームを設定する
        /// *0f～1fの数値指定
        /// </summary>
        /// <param name="volume">ボリューム値</param>
        void SetVolumeSE(float volume);
    }
}
