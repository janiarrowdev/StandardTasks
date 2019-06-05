using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsFramework.Test 
{
    public class Program : Global.Base
    {
        [BeforeScenario]
        public void SetUp()
        {
            //Launch the browser
            Inititalize();
            Thread.Sleep(500);
        }

       // [AfterScenario]
        public void EndScenario()
        {
            TearDown();
        }

    }
}
