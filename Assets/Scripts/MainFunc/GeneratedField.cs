using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratedField : MonoBehaviour
{
    public int X,Y;
    private Vector2 move;
    public Transform transformObjectCube;
    public GameObject gameObject;
    private List<Vector3> spawnList = new List <Vector3> ();    

    void Start()
    {
        Vector3 startPosition = transformObjectCube.position;
        spawnList.Add(startPosition);
        for (int y = 0;y<Y;y++){
             for (int x = 0;x<X;x++){
                 if(x==0)continue;
                 spawnList.Add(new Vector3(spawnList[x-1].x + 0.322f, spawnList[y*X].y,0f));
                 //GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
             } 
             if (y==Y-1) break;
             else spawnList.Add(new Vector3(spawnList[y*X].x, spawnList[y*X].y + 0.322f));
         }
         for (int i = 0; i < spawnList.Count;i++){
             GameObject Cube = Instantiate(gameObject,spawnList[i],Quaternion.identity);
         }
    }

    void Update()
    {
        
    }
}
