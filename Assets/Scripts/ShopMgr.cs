using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMgr : MonoBehaviour
{
    public Cardhander cardhander;
    public SpriteMgr spriteMgr;


    public GameObject prefabSource;
    public GameObject pool;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if(GUI.Button(new Rect(10,70,50,30),"click"))
        {
            cardhander.Amount = 888;
            cardhander.Product = "酷東西";
            cardhander.ShopItem= spriteMgr.sprites[0];
        }
        if(GUI.Button(new Rect(10,100,50,30),"+" ))
        {
            GameObject target = Instantiate(prefabSource);
            target.transform.parent = pool.transform;
            //reset
            target.transform.localScale = Vector3.one;

            //fill data
            Cardhander _card = target.GetComponent<Cardhander>();
            _card.ShopItem = spriteMgr.sprites[(int)Random.Range(0,6)];
            _card.Amount = (int)Random.Range(100,999);
            _card.Product = "酷東西"+(int)Random.Range(0,6);
            _card.Cost = (int)Random.Range(10,9999);
        }
    } 
}
