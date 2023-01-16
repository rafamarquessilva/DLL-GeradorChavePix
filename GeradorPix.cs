using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorChavePix
{
    public class GeradorPix
    {
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        public static List<string> GetChavesPix(int numerosChaves)
        {
            if (numerosChaves <= 0) return null;

            List<string> chavesPix = new List<string>();

            for (int i = 0; i < numerosChaves; i++)
            {
                chavesPix.Add(GetChavePix());
            }
            return chavesPix;
        }

    }
}
