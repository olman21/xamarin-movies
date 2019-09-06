using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xamarin.Movies.Extensions
{
    public static class IEnumerableExtensions
    {
        public static void LoadFromList<T>(this ObservableCollection<T> target, IEnumerable<T> source)
        {
            target.Clear();
            foreach(var item in source)
            {
                target.Add(item);
            }
        }
    }
}
