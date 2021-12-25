using Core.Utulities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utulities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)   //params burada IResult olanlari array ederek bir arrayin ichine yigir
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
