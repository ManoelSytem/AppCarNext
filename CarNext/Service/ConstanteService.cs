using CarNext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Service
{
    public class ConstanteService
    {
        public static List<ObjectConstant> ObterListPrefixo()
        {

            var listaPrefixo = new List<ObjectConstant>()
            {
                new() {Key= 1, Value = "54", Description =  "Agentina"},
                new() {Key= 2, Value = "591", Description =  "Bolívia"},
                new() {Key= 3, Value = "55", Description =  "Brasil"},
                new() {Key= 4, Value = "56", Description =  "Chile"},
                new() {Key= 5, Value = "57", Description =  "56"}
  
            };

            return listaPrefixo;

        }

    }
}
