using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class RealImage : IImage
    {
        public string _fileName;
        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadImageFromDisk(_fileName);
        }

        public string Status { get; private set; }

        private void LoadImageFromDisk(string fileName)
        {
            Status = $"Loaded {fileName}";
        }
        
        public string Draw()
        {
            Status = $"Drawing {_fileName}";
            return Status;
        }
    }
}
