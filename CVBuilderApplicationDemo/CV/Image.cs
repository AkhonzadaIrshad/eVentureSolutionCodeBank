using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilderApplicationDemo.CV
{
  public class Image
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
