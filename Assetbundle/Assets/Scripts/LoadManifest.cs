using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManifest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AssetBundle ab =  AssetBundle.LoadFromFile("AssetBundles/AssetBundles");
        AssetBundleManifest manifest = ab.LoadAsset<AssetBundleManifest>("AssetBundleManifest");

        //foreach (string name in manifest.GetAllAssetBundles())
        //{
        //    Debug.Log(name);
        //}
        string [] strs = manifest.GetAllDependencies("cubewall.unity3d");
        foreach (string name in strs)
        {
            Debug.Log(name);
            AssetBundle.LoadFromFile("AssetBundles/" + name);
        }
        AssetBundle abCube = AssetBundle.LoadFromFile("AssetBundles/cubewall.unity3d");
        GameObject obj = abCube.LoadAsset<GameObject>("CubeWall");
        Instantiate(obj);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
