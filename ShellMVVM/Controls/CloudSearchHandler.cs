using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ShellMVVM.Models;
using System.Linq;
namespace ShellMVVM.Controls
{
    public class CloudSearchHandler: SearchHandler
    {
        public IList<Cloud> Clouds { set; get; }
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if (string.IsNullOrWhiteSpace(newValue))
                ItemsSource = null;
            else
                ItemsSource = Clouds
                    .Where(cloud => cloud.Name.ToLower().Contains(newValue.ToLower())).ToList<Cloud>();
        }
    }
}
