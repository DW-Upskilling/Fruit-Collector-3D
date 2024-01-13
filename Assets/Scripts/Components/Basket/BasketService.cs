using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;

namespace FruitCollector3D.Components.Basket
{
    public class BasketService : Service
    {
        private List<BasketView> _basketList;

        public BasketService(List<BasketView> _basketList) { 
            this._basketList = _basketList;
        }

        public override void Start()
        {
            foreach(BasketView basketView in _basketList)
            {
                basketView.gameObject.SetActive(false);
            }
        }

        public IEnumerator SwitchBaskets()
        {
            while (_basketList.Count > 0)
            {
                int index = Random.Range(0, _basketList.Count-1);

                _basketList[index].gameObject.SetActive(true);
                
                yield return new WaitForSeconds(30f);
                
                _basketList[index].gameObject.SetActive(false);
            }
            yield return null;
        }
    }
}
