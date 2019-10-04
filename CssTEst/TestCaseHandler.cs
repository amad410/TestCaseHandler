using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CssTEst
{
    public class TestCaseHandler
    {

        public void Invoke(Action method)
        {
            try
            {
                method.Invoke();

            }
            catch (Exception ex)
            {
                throw new Exception("here is a good exception of " + ex.Message);
            }
        }
    }
}
