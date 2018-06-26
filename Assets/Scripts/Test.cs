using UnityEngine;
using Tangzx.ABSystem;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    AssetBundleManager manager;
    public Transform transform;

    void Start()
    {
        manager = gameObject.AddComponent<AssetBundleManager>();
        manager.Init(() =>
        {
            LoadObjects();
        });
    }

    void LoadObjects()
    {
        manager.Load("Assets.Prefabs.Cube.prefab", (a) =>
        {
            GameObject go = Instantiate(a.mainObject) as GameObject;//a.Instantiate();
           // go.GetComponent<Renderer>().enabled = true;
            go.transform.localPosition = new Vector3(3, 3, 3);
          //  go.transform.SetParent(transform);
        });
        //manager.Load("Assets.Prefabs.Cube.prefab.ab", (a) =>
        //{
        //    GameObject go = a.Instantiate();
        //    go.transform.localPosition = new Vector3(6, 3, 3);
        //});
        //manager.Load("Assets.Prefabs.Plane.prefab.ab", (a) =>
        //{
        //    GameObject go = a.Instantiate();
        //    go.transform.localPosition = new Vector3(9, 3, 3);
        //});
        //manager.Load("Assets.Prefabs.Capsule.prefab.ab", (a) =>
        //{
        //    GameObject go = a.Instantiate();
        //    go.transform.localPosition = new Vector3(12, 3, 3);
        //});
    }
}