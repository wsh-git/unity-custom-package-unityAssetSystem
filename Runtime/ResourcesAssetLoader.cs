using System;
using UnityEngine;
using UnityEngine.U2D;

namespace Wsh.Asset {

    public class ResourcesAssetLoader : IAssetLoader {
        private void InitObj(Transform transform) {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.localScale = Vector3.one;
        }

        public GameObject Instantiate(GameObject prefab, GameObject parent) {
            GameObject go;
            if(parent != null) {
                go = GameObject.Instantiate(prefab, parent.transform);
            } else {
                go = GameObject.Instantiate(prefab);
            }
            InitObj(go.transform);
            return go;
        }

        public void InstantiateAsync(string prefabPath, GameObject parent, Action<GameObject> onComplete) {
            LoadPrefabAsync(prefabPath, prefab => {
                GameObject go = Instantiate(prefab, parent);
                onComplete?.Invoke(go);
            });
        }
        
        public void LoadAudioClipAsync(string path, Action<AudioClip> onComplete) {
            AudioClip clip = Resources.Load<AudioClip>(path);
            onComplete?.Invoke(clip);
        }

        public void LoadPrefabAsync(string prefabPath, Action<GameObject> onComplete) {
            GameObject go = (GameObject)Resources.Load(prefabPath);
            onComplete?.Invoke(go);
        }

        public void LoadScriptableData<T>(string path, Action<T> onComplete) where T : ScriptableObject {
            var data = Resources.Load<T>(path);
            onComplete?.Invoke(data);
        }

        public void LoadSpriteAtlasAysnc(string path, Action<SpriteAtlas> onComplete) {
            SpriteAtlas spriteAtlas = (SpriteAtlas)Resources.Load(path);
            onComplete?.Invoke(spriteAtlas);
        }

        public void LoadTextAssetAsync(string path, Action<TextAsset> onComplete) {
            TextAsset textAsset = (TextAsset)Resources.Load(path);
            onComplete?.Invoke(textAsset);
        }

        public void LoadMaterialAsync(string path, Action<Material> onComplete) {
            Material material = (Material)Resources.Load(path);
            onComplete?.Invoke(material);
        }

        public void LoadTextureAsync(string path, Action<Texture> onComplete) {
            Texture texture = (Texture)Resources.Load(path);
            onComplete?.Invoke(texture);
        }

        public void LoadTexture2DAsync(string path, Action<Texture2D> onComplete) {
            Texture2D texture2D = Resources.Load<Texture2D>(path);
            onComplete?.Invoke(texture2D);
        }

        public void LoadFontAsync(string path, Action<Font> onComplete) {
            Font font = (Font)Resources.Load(path);
            onComplete?.Invoke(font);
        }

    }

}