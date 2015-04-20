using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCubeSolver
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
				
		protected void raisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		public void raiseAllPropertiesChanged()
		{
			foreach (PropertyInfo property in this.GetType().GetProperties())
			{
				raisePropertyChanged(property.Name);
			}
		}
	}
}
