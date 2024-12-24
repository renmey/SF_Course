﻿using ObserverRealExample.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverRealExample
{
    internal class Stock : IObservable
    {
        /// <summary>
        /// Информация о торгах
        /// </summary>
        StockData _sData;
        List<IObserver> observers;
        public Stock()
        {
            observers = new List<IObserver>();
            _sData = new StockData();
        }
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(_sData);
            }
        }
        public void Market()
        {
            Random rnd = new Random();
            _sData.USD = rnd.Next(70, 90);
            _sData.Euro = rnd.Next(80, 100);
            NotifyObservers();
        }


    }
}
