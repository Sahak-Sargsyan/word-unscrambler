using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordUnscrambler.source
{
    public class FileReader
    {
        public string[] Read(string fileName)
        {
            string[] result;
            try
            {
                result = File.ReadAllLines(fileName);
            }catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }
    }
}
