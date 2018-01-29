using System;
using System.ComponentModel;

namespace HelloWorld
{

    /// <summary>
    /// Class for Hello World 
    /// </summary>
    public class CHello : INotifyPropertyChanged
    {

        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Input Data
        /// </summary>
        private string sStr = "";

        public string Text
        {
            get
            {
                return this.sStr;
            }
            set
            {
                if (!value.Equals(this.sStr))
                {
                    this.sStr = value;
                    this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }

    }
}
