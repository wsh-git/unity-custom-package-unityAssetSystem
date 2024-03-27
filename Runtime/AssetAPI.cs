using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Wsh.Asset {

    public class AssetAPI {

        private static IAssetLoader m_assetLoader;

        public static void Init(IAssetLoader assetLoader=null) {
            if(assetLoader != null) {
                m_assetLoader = assetLoader;
            } else {
                m_assetLoader = new ResourcesAssetLoader();
            }
        }
        
        public static void LoadAudioClipAsync(string path, Action<AudioClip> onComplete) {
            m_assetLoader.LoadAudioClipAsync(path, onComplete);
        }

        public static void LoadPrefabAsync(string prefabPath, Action<GameObject> onComplete) {
            m_assetLoader.LoadPrefabAsync(prefabPath, onComplete);
        }

        public static void LoadScriptableData<T>(string path, Action<T> onComplete) where T : ScriptableObject {
            m_assetLoader.LoadScriptableData<T>(path, onComplete);
        }

        public static void LoadMaterialAsync(string path, Action<Material> onComplete) {
            m_assetLoader.LoadMaterialAsync(path, onComplete);
        }

        public static void LoadTextureAsync(string path, Action<Texture> onComplete) {
            m_assetLoader.LoadTextureAsync(path, onComplete);
        }

        public static void LoadTexture2DAsync(string path, Action<Texture2D> onComplete) {
            m_assetLoader.LoadTexture2DAsync(path, onComplete);
        }

        public static void LoadSpriteAtlasAysnc(string path, Action<SpriteAtlas> onComplete) {
            m_assetLoader.LoadSpriteAtlasAysnc(path, onComplete);
        }

        public static void LoadTextAssetAsync(string path, Action<TextAsset> onComplete) {
            m_assetLoader.LoadTextAssetAsync(path, onComplete);
        }

        public static void LoadFontAsync(string path, Action<Font> onComplete) {
            m_assetLoader.LoadFontAsync(path, onComplete);
        }

        public static void InstantiateAsync(string prefabPath, GameObject parent, Action<GameObject> onComplete) {
            m_assetLoader.InstantiateAsync(prefabPath, parent, onComplete);
        }

        public static GameObject Instantiate(GameObject prefab, GameObject parent) {
            return m_assetLoader.Instantiate(prefab, parent);
        }
    }
}