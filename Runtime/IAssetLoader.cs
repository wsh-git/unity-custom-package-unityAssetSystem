using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Wsh.Asset {

    public interface IAssetLoader {
        public GameObject Instantiate(GameObject prefab, GameObject parent);
        public void InstantiateAsync(string prefabPath, GameObject parent, Action<GameObject> onComplete);
        public void LoadAudioClipAsync(string path, Action<AudioClip> onComplete);
        public void LoadPrefabAsync(string prefabPath, Action<GameObject> onComplete);
        public void LoadScriptableData<T>(string path, Action<T> onComplete) where T : ScriptableObject;
        public void LoadSpriteAtlasAysnc(string path, Action<SpriteAtlas> onComplete);
        public void LoadTextAssetAsync(string path, Action<TextAsset> onComplete);
        public void LoadMaterialAsync(string path, Action<Material> onComplete);
        public void LoadTextureAsync(string path, Action<Texture> onComplete);
        public void LoadTexture2DAsync(string path, Action<Texture2D> onComplete);
        public void LoadFontAsync(string path, Action<Font> onComplete);
    }
}