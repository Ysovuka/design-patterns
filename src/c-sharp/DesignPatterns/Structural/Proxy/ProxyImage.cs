using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class ProxyImage : IImage
    {
        private string _fileName;
        private RealImage _realImage;
        public ProxyImage(string fileName)
        {
            _fileName = fileName;
        }
        
        public string Draw()
        {
            StringBuilder builder = new StringBuilder();
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
                builder.Append(_realImage.Status + " ");
            }

            builder.Append(_realImage.Draw());

            return builder.ToString();
        }
    }
}
